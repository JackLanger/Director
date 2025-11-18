using Director.Core;
using Director.Core.Model;

namespace Director.Presentation;

public partial class MainViewModel : ObservableObject {
    private readonly IAuthenticationService _authentication;

    private readonly IRepositoryDataLoader _dataLoader;

    private readonly IStringLocalizer _localizer;

    private readonly INavigator _navigator;


    [ObservableProperty]
    private string? name;

    [ObservableProperty]
    private IList<Repository> repositories;

    public MainViewModel(
        IRepositoryDataLoader dataLoader,
        IStringLocalizer localizer,
        IOptions<AppConfig> appInfo,
        IAuthenticationService authentication,
        INavigator navigator,
        IList<Repository> repositories
    )
    {
        _localizer = localizer;
        _dataLoader = dataLoader;
        _navigator = navigator;
        _authentication = authentication;
        Title = "Main";
        Title += $" - {localizer["ApplicationName"]}";
        Title += $" - {appInfo?.Value?.Environment}";
        GoToSecond = new AsyncRelayCommand<Repository>(GoToSecondView);
        Logout = new AsyncRelayCommand(DoLogout);
        Repositories = repositories;
    }

    public string? Title { get; }

    public ICommand GoToSecond { get; }

    public ICommand Logout { get; }


    private async Task GoToSecondView(Repository? repository)
    {
        if (repository is null)
        {
            return;
        }

        await _navigator.NavigateViewModelAsync<SecondViewModel>(this, data: repository);
    }

    public async Task DoLogout(CancellationToken token)
    {
        await _authentication.LogoutAsync(token);
    }
}
