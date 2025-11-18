using Director.Core;

namespace Director.Presentation;

public partial class LoginViewModel : ObservableObject {
    private readonly IAuthenticationService _authentication;

    private readonly IRepositoryDataLoader _dataLoader;


    private readonly IDispatcher _dispatcher;

    private readonly INavigator _navigator;

    [ObservableProperty]
    private string? _password;

    [ObservableProperty]
    private string? _username;

    public LoginViewModel(
        IRepositoryDataLoader dataLoader,
        IDispatcher dispatcher,
        INavigator navigator,
        IAuthenticationService authentication)
    {
        _dispatcher = dispatcher;
        _navigator = navigator;
        _authentication = authentication;
        _dataLoader = dataLoader;
        Login = new AsyncRelayCommand(DoLogin);
    }

    public string Title { get; } = "Login";

    public ICommand Login { get; }

    private async Task DoLogin()
    {
        var success = await _authentication.LoginAsync(_dispatcher, new Dictionary<string, string> { { nameof(Username), Username ?? string.Empty }, { nameof(Password), Password ?? string.Empty } });

        if (success)
        {
            var (repos, error) = await _dataLoader.LoadRepositoriesAsync(Username!);

            if (error != null)
            {
                // await _navigator.NavigateViewModelAsync<MainViewModel>(this, Qualifiers.ClearBackStack);
            }
            else
            {
                await _navigator.NavigateViewModelAsync<MainViewModel>(this, Qualifiers.ClearBackStack, repos);
            }

        }
    }
}
