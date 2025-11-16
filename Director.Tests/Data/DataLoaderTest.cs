using Director.Core;
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
        var repos = repositoryDataLoader.LoadRepositories("octocat");

        Assert.NotNull(repos);
        Assert.NotEmpty(repos);
        _testOutputHelper.WriteLine($"Found: {repos.Count.ToString()} repositories.");
    }
}
