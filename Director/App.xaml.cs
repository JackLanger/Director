using Director.Core;
using Director.Core.Data;
using Director.Core.Model;

namespace Director;

public partial class App : Application {

    private string? _username;

    /// <summary>
    ///     Initializes the singleton application object. This is the first line of authored code
    ///     executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
    {
        InitializeComponent();
    }

    protected Window? MainWindow { get; private set; }
    protected IHost? Host { get; private set; }

    protected override async void OnLaunched(LaunchActivatedEventArgs args)
    {

        var builder = this.CreateBuilder(args)
            // Add navigation support for toolkit controls such as TabBar and NavigationView
            .UseToolkitNavigation()
            .Configure(host => host
#if DEBUG
                // Switch to Development environment when running in DEBUG
                .UseEnvironment(Environments.Development)
#endif
                .UseConfiguration(configure: configBuilder =>
                    configBuilder
                        .EmbeddedSource<App>()
                        .Section<AppConfig>()
                )
                // Enable localization (see appsettings.json for supported languages)
                .UseLocalization()
                .UseAuthentication(auth =>
                    auth.AddCustom(custom =>
                        custom
                            .Login((sp, dispatcher, credentials, cancellationToken) => {
                                // TODO: Write code to process credentials that are passed into the LoginAsync method
                                if (credentials?.TryGetValue(nameof(LoginViewModel.Username), out var username) ?? false &&
                                    !username.IsNullOrEmpty())
                                {
                                    _username = username;
                                    // Return IDictionary containing any tokens used by service calls or in the app
                                    credentials ??= new Dictionary<string, string>();
                                    credentials[TokenCacheExtensions.AccessTokenKey] = "SampleToken";
                                    credentials[TokenCacheExtensions.RefreshTokenKey] = "RefreshToken";
                                    credentials["Expiry"] = DateTime.Now.AddMinutes(5).ToString("g");

                                    return ValueTask.FromResult<IDictionary<string, string>?>(credentials);
                                }

                                // Return null/default to fail the LoginAsync method
                                return ValueTask.FromResult<IDictionary<string, string>?>(default);
                            })
                            .Refresh((sp, tokenDictionary, cancellationToken) => {
                                // TODO: Write code to refresh tokens using the currently stored tokens
                                if ((tokenDictionary?.TryGetValue(TokenCacheExtensions.RefreshTokenKey, out var refreshToken) ?? false) &&
                                    !refreshToken.IsNullOrEmpty() &&
                                    (tokenDictionary?.TryGetValue("Expiry", out var expiry) ?? false) &&
                                    DateTime.TryParse(expiry, out var tokenExpiry) &&
                                    tokenExpiry > DateTime.Now)
                                {
                                    // Return IDictionary containing any tokens used by service calls or in the app
                                    tokenDictionary ??= new Dictionary<string, string>();
                                    tokenDictionary[TokenCacheExtensions.AccessTokenKey] = "NewSampleToken";
                                    tokenDictionary["Expiry"] = DateTime.Now.AddMinutes(5).ToString("g");

                                    return ValueTask.FromResult<IDictionary<string, string>?>(tokenDictionary);
                                }

                                // Return null/default to fail the Refresh method
                                return ValueTask.FromResult<IDictionary<string, string>?>(default);
                            }), "CustomAuth")
                )
                .ConfigureServices((context, services) => {

                    services.AddSingleton<IRepositoryDataLoader, GithubRepositoryDataLoader>();

                    // TODO: Register your services
                    //services.AddSingleton<IMyService, MyService>();
                })
                .UseNavigation(RegisterRoutes)
            );

        MainWindow = builder.Window;

#if DEBUG
        MainWindow.UseStudio();
#endif
        MainWindow.SetWindowIcon();

        Host = await builder.NavigateAsync<Shell>
        (async (services, navigator) => {
            var auth = services.GetRequiredService<IAuthenticationService>();
            var authenticated = await auth.RefreshAsync();

            if (authenticated)
            {
                var dataLoader = services.GetRequiredService<IRepositoryDataLoader>();
                var (repos, err) = await dataLoader.LoadRepositoriesAsync(_username ?? "octocat");

                if (err != null)
                {
                    Console.WriteLine(err.GetReason());
                }

                await navigator.NavigateViewModelAsync<MainViewModel>(this, Qualifiers.Nested, repos);
            }
            else
            {
                await navigator.NavigateViewModelAsync<LoginViewModel>(this, Qualifiers.Nested);
            }
        });
    }

    private static void RegisterRoutes(IViewRegistry views, IRouteRegistry routes)
    {
        views.Register(
        new ViewMap(ViewModel: typeof(ShellViewModel)),
        new ViewMap<LoginPage, LoginViewModel>(),
        new DataViewMap<MainPage, MainViewModel, IList<Repository>>(),
        new DataViewMap<SecondPage, SecondViewModel, Repository>()
        );

        routes.Register(
        new RouteMap("", views.FindByViewModel<ShellViewModel>(),
        Nested:
        [
            new RouteMap("Login", views.FindByViewModel<LoginViewModel>()),
            new RouteMap("Main", views.FindByViewModel<MainViewModel>(), true),
            new RouteMap("Second", views.FindByViewModel<SecondViewModel>())
        ]
        )
        );
    }
}
