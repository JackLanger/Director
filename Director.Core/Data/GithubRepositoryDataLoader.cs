using System.Text.Json;
using Director.Core.Model;

namespace Director.Core;

public class GithubRepositoryDataLoader : IRepositoryDataLoader {

    public List<GithubRepository> LoadRepositories(string user)
    {
        return LoadRepositoriesAsync(user).GetAwaiter().GetResult();
    }

    public List<GithubRepository> LoadRepositories(string user, IGithubAuthenticator authenticator)
    {
        throw new NotImplementedException();
    }

    public async Task<List<GithubRepository>> LoadRepositoriesAsync(string user)
    {
        using var client = new HttpClient();

        client.DefaultRequestHeaders.UserAgent.ParseAdd("DirectorApp");
        client.BaseAddress = new Uri(IRepositoryDataLoader.GithubApiBaseUrl);
        var response = await client.GetStringAsync($"users/{user}/repos");

        return JsonSerializer.Deserialize<List<GithubRepository>>(response) ?? [];
    }

    public Task<List<GithubRepository>> LoadRepositoriesAsync(string user, IGithubAuthenticator authenticator)
    {
        throw new NotImplementedException();
    }

    public Task<List<GithubBranch>> LoadBranches(string user, GithubRepository repository, IGithubAuthenticator authenticator)
    {
        throw new NotImplementedException();
    }
}
