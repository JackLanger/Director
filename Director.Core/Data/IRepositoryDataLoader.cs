using Director.Core.Model;

namespace Director.Core;

public interface IRepositoryDataLoader {

    protected static string GithubApiBaseUrl => "https://api.github.com/";
    /// <summary>
    ///     Load repositories synchronously, will load only public and visible repositories.
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    List<GithubRepository> LoadRepositories(string user);
    /// <summary>
    ///     Load repositories synchronously, will load all non archived repositories.
    /// </summary>
    /// <param name="user"></param>
    /// <param name="authenticator"></param>
    /// <returns></returns>
    List<GithubRepository> LoadRepositories(string user, IGithubAuthenticator authenticator);
    /// <summary>
    ///     Load repositories asynchronously, will load only public and visible repositories.
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task<List<GithubRepository>> LoadRepositoriesAsync(string user);

    /// <summary>
    ///     Load repositories asynchronously, will load all non archived repositories.
    /// </summary>
    /// <param name="user"></param>
    /// <param name="authenticator"></param>
    /// <returns></returns>
    Task<List<GithubRepository>> LoadRepositoriesAsync(string user, IGithubAuthenticator authenticator);

    /// <summary>
    ///     Will load all branches for a given repository.
    /// </summary>
    /// <param name="user"></param>
    /// <param name="repository"></param>
    /// <param name="authenticator"></param>
    /// <returns></returns>
    Task<List<GithubBranch>> LoadBranches(string user, GithubRepository repository, IGithubAuthenticator authenticator);
}
