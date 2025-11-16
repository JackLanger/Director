using System.Text.Json.Serialization;

namespace Director.Core.Model;

public class GithubRepository
{
    public ulong Id { get; set; }
    public string NodeId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public bool Private { get; set; }
    public GithubRepositoryOwner Owner { get; set; } = default!;
    public string HtmlUrl { get; set; } = default!;
    public string? Description { get; set; }
    public bool Fork { get; set; }
    public string Url { get; set; } = default!;
    public string ForksUrl { get; set; } = default!;
    public string KeysUrl { get; set; } = default!;
    public string CollaboratorsUrl { get; set; } = default!;
    public string TeamsUrl { get; set; } = default!;
    public string HooksUrl { get; set; } = default!;
    public string IssueEventsUrl { get; set; } = default!;
    public string EventsUrl { get; set; } = default!;
    public string AssigneesUrl { get; set; } = default!;
    public string BranchesUrl { get; set; } = default!;
    public string TagsUrl { get; set; } = default!;
    public string BlobsUrl { get; set; } = default!;
    public string GitTagsUrl { get; set; } = default!;
    public string GitRefsUrl { get; set; } = default!;
    public string TreesUrl { get; set; } = default!;
    public string StatusesUrl { get; set; } = default!;
    public string LanguagesUrl { get; set; } = default!;
    public string StargazersUrl { get; set; } = default!;
    public string ContributorsUrl { get; set; } = default!;
    public string SubscribersUrl { get; set; } = default!;
    public string SubscriptionUrl { get; set; } = default!;
    public string CommitsUrl { get; set; } = default!;
    public string GitCommitsUrl { get; set; } = default!;
    public string CommentsUrl { get; set; } = default!;
    public string IssueCommentUrl { get; set; } = default!;
    public string ContentsUrl { get; set; } = default!;
    public string CompareUrl { get; set; } = default!;
    public string MergesUrl { get; set; } = default!;
    public string ArchiveUrl { get; set; } = default!;
    public string DownloadsUrl { get; set; } = default!;
    public string IssuesUrl { get; set; } = default!;
    public string PullsUrl { get; set; } = default!;
    public string MilestonesUrl { get; set; } = default!;
    public string NotificationsUrl { get; set; } = default!;
    public string LabelsUrl { get; set; } = default!;
    public string ReleasesUrl { get; set; } = default!;
    public string DeploymentsUrl { get; set; } = default!;
    public string CreatedAt { get; set; } = default!;
    public string UpdatedAt { get; set; } = default!;
    public string PushedAt { get; set; } = default!;
    public string GitUrl { get; set; } = default!;
    public string SshUrl { get; set; } = default!;
    public string CloneUrl { get; set; } = default!;
    public string SvnUrl { get; set; } = default!;
    public string? Homepage { get; set; }
    public ulong Size { get; set; }
    public uint StargazersCount { get; set; }
    public uint WatchersCount { get; set; }
    public string? Language { get; set; }
    public bool HasIssues { get; set; }
    public bool HasProjects { get; set; }
    public bool HasDownloads { get; set; }
    public bool HasWiki { get; set; }
    public bool HasPages { get; set; }
    public bool HasDiscussions { get; set; }
    public uint ForksCount { get; set; }
    public string? MirrorUrl { get; set; }
    public bool Archived { get; set; }
    public bool Disabled { get; set; }
    public uint OpenIssuesCount { get; set; }
    public object? License { get; set; }
    public bool AllowForking { get; set; }
    public bool IsTemplate { get; set; }
    public bool WebCommitSignoffRequired { get; set; }
    public List<string> Topics { get; set; } = new();
    public string Visibility { get; set; } = default!;
    public uint Forks { get; set; }
    public uint OpenIssues { get; set; }
    public uint Watchers { get; set; }
    public string DefaultBranch { get; set; } = default!;
}

public class GithubRepositoryOwner
{
    public string Login { get; set; } = default!;
    public ulong Id { get; set; }
    public string NodeId { get; set; } = default!;
    public string AvatarUrl { get; set; } = default!;
    public string? GravatarId { get; set; }
    public string Url { get; set; } = default!;
    public string HtmlUrl { get; set; } = default!;
    public string FollowersUrl { get; set; } = default!;
    public string FollowingUrl { get; set; } = default!;
    public string GistsUrl { get; set; } = default!;
    public string StarredUrl { get; set; } = default!;
    public string SubscriptionsUrl { get; set; } = default!;
    public string OrganizationsUrl { get; set; } = default!;
    public string ReposUrl { get; set; } = default!;
    public string EventsUrl { get; set; } = default!;
    public string ReceivedEventsUrl { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    public string? UserViewType { get; set; }
    public bool SiteAdmin { get; set; }
}

public class GithubBranch {
    
}
