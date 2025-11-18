using System.Text.Json;
using Director.Core.Model;

namespace Director.Core.Data;

public class GithubRepositoryDataLoader : IRepositoryDataLoader {


    public (List<Repository>, Error?) LoadRepositories(string user)
    {
        return LoadRepositoriesAsync(user).GetAwaiter().GetResult();
    }

    public (List<Repository>, Error?) LoadRepositories(string user, IGithubAuthenticator authenticator)
    {
        return LoadRepositoriesAsync(user, authenticator).GetAwaiter().GetResult();
    }

    public async Task<(List<Repository>, Error?)> LoadRepositoriesAsync(string user)
    {
        using var client = new HttpClient();

        client.DefaultRequestHeaders.UserAgent.ParseAdd("DirectorApp");
        client.BaseAddress = new Uri(IRepositoryDataLoader.GithubApiBaseUrl);

        var response = await client.GetAsync($"users/{user}/repos");
        var error = !response.IsSuccessStatusCode ? new Error(response.ReasonPhrase!, response.StatusCode) : null;
        var json = await response.Content.ReadAsStringAsync();
        var result = response.IsSuccessStatusCode ? JsonSerializer.Deserialize<List<Repository>>(json) ?? [] : [];

        return (result, error);
    }

    public Task<(List<Repository>, Error?)> LoadRepositoriesAsync(string user, IGithubAuthenticator authenticator)
    {
        throw new NotImplementedException();
    }

    public Task<(List<Branch>, Error?)> LoadBranches(string user, Repository repository, IGithubAuthenticator authenticator)
    {
        throw new NotImplementedException();
    }
}
