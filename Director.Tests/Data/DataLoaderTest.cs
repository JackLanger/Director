using Director.Core;
using Director.Core.Data;
using Xunit.Abstractions;

namespace Director.Tests.Data;

public class DataLoaderTest {
    private readonly ITestOutputHelper _testOutputHelper;

    public DataLoaderTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Assert_Works_Fine()
    {
        Assert.Equal(1, 1);
    }

    [Fact]
    public void Test_LoadRepositories_Does_Return_Response()
    {

        IRepositoryDataLoader repositoryDataLoader = new GithubRepositoryDataLoader();
        var (repos, error) = repositoryDataLoader.LoadRepositories("octocat");

        Assert.NotNull(repos);
        Assert.NotEmpty(repos);
        _testOutputHelper.WriteLine($"Found: {repos.Count.ToString()} repositories.");
    }

    [Fact]
    public async Task Test_LoadRepositoriesAsync_Does_Return_Response()
    {

        IRepositoryDataLoader repositoryDataLoader = new GithubRepositoryDataLoader();
        var (repos, error) = await repositoryDataLoader.LoadRepositoriesAsync("octocat");

        Assert.Null(error);
        Assert.NotNull(repos);
        Assert.NotEmpty(repos);
        _testOutputHelper.WriteLine($"Found: {repos.Count.ToString()} repositories.");
    }

    [Fact]
    public async Task Test_LoadRepositoriesAsync_InvalidUser_Returns_Error()
    {

        IRepositoryDataLoader repositoryDataLoader = new GithubRepositoryDataLoader();
        var (repos, error) = await repositoryDataLoader.LoadRepositoriesAsync("illegal user 123!@#");

        Assert.NotNull(error);
        Assert.NotNull(repos);
        Assert.Empty(repos);
        _testOutputHelper.WriteLine($"Found: {repos.Count.ToString()} repositories.");
    }

    [Fact]
    public void Test_LoadRepositories_DoesNot_Return_EmptyObjects()
    {
        IRepositoryDataLoader repositoryDataLoader = new GithubRepositoryDataLoader();
        var (repos, error) = repositoryDataLoader.LoadRepositories("octocat");

        Assert.Null(error);

        foreach (var repo in repos)
        {
            Assert.False(string.IsNullOrEmpty(repo.Name));
            Assert.False(string.IsNullOrEmpty(repo.FullName));
            Assert.False(string.IsNullOrEmpty(repo.HtmlUrl));
        }
    }
}
