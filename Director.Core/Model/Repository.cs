using System.Text.Json.Serialization;

namespace Director.Core.Model;

/// <summary>
///     <p>
///         Example Repository Object:
///     </p>
///     <ul>
///         <li>"id" : 132935648,</li>
///         <li>"node_id" : "MDEwOlJlcG9zaXRvcnkxMzI5MzU2NDg=",</li>
///         <li>"name" : "boysenberry-repo-1",</li>
///         <li>"full_name" : "octocat/boysenberry-repo-1",</li>
///         <li>"private" : false,</li>
///         <li>"owner" : GithubRepositoryOwner</li>
///         <li>"html_url" : "https://github.com/octocat/boysenberry-repo-1",</li>
///         <li>"description" : "Testing",</li>
///         <li>"fork" : true,</li>
///         <li>"url" : "https://api.github.com/repos/octocat/boysenberry-repo-1",</li>
///         <li>"forks_url" : "https://api.github.com/repos/octocat/boysenberry-repo-1/forks",</li>
///         <li>"keys_url" : "https://api.github.com/repos/octocat/boysenberry-repo-1/keys{/key_id}",</li>
///         <li>"collaborators_url" :</li>
///         <li>"https://api.github.com/repos/octocat/boysenberry-repo-1/collaborators{/collaborator}",</li>
///         <li>"teams_url" : "https://api.github.com/repos/octocat/boysenberry-repo-1/teams",</li>
///         <li>"hooks_url" : "https://api.github.com/repos/octocat/boysenberry-repo-1/hooks",</li>
///         <li>"issue_events_url" :</li>
///         <li>"https://api.github.com/repos/octocat/boysenberry-repo-1/issues/events{/number}",</li>
///         <li>"events_url" : "https://api.github.com/repos/octocat/boysenberry-repo-1/events",</li>
///         <li>
///             "assignees_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/assignees{/user}",
///         </li>
///         <li>
///             "branches_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/branches{/branch}",
///         </li>
///         <li>"tags_url" : "https://api.github.com/repos/octocat/boysenberry-repo-1/tags",</li>
///         <li>
///             "blobs_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/git/blobs{/sha}",
///         </li>
///         <li>
///             "git_tags_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/git/tags{/sha}",
///         </li>
///         <li>
///             "git_refs_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/git/refs{/sha}",
///         </li>
///         <li>
///             "trees_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/git/trees{/sha}",
///         </li>
///         <li>
///             "statuses_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/statuses/{sha}",
///         </li>
///         <li>"languages_url" : "https://api.github.com/repos/octocat/boysenberry-repo-1/languages",</li>
///         <li>
///             "stargazers_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/stargazers",
///         </li>
///         <li>
///             "contributors_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/contributors",
///         </li>
///         <li>
///             "subscribers_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/subscribers",
///         </li>
///         <li>
///             "subscription_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/subscription",
///         </li>
///         <li>
///             "commits_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/commits{/sha}",
///         </li>
///         <li>"git_commits_url" :</li>
///         <li>"https://api.github.com/repos/octocat/boysenberry-repo-1/git/commits{/sha}",</li>
///         <li>
///             "comments_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/comments{/number}",
///         </li>
///         <li>"issue_comment_url" :</li>
///         <li>"https://api.github.com/repos/octocat/boysenberry-repo-1/issues/comments{/number}",</li>
///         <li>
///             "contents_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/contents/{+path}",
///         </li>
///         <li>"compare_url" :</li>
///         <li>"https://api.github.com/repos/octocat/boysenberry-repo-1/compare/{base}...{head}",</li>
///         <li>"merges_url" : "https://api.github.com/repos/octocat/boysenberry-repo-1/merges",</li>
///         <li>"archive_url" :</li>
///         <li>"https://api.github.com/repos/octocat/boysenberry-repo-1/{archive_format}{/ref}",</li>
///         <li>"downloads_url" : "https://api.github.com/repos/octocat/boysenberry-repo-1/downloads",</li>
///         <li>
///             "issues_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/issues{/number}",
///         </li>
///         <li>"pulls_url" : "https://api.github.com/repos/octocat/boysenberry-repo-1/pulls{/number}",</li>
///         <li>"milestones_url" :</li>
///         <li>"https://api.github.com/repos/octocat/boysenberry-repo-1/milestones{/number}",</li>
///         <li>"notifications_url" :</li>
///         <li>"https://api.github.com/repos/octocat/boysenberry-repo-1/notifications{?since,all,participating}",</li>
///         <li>"labels_url" : "https://api.github.com/repos/octocat/boysenberry-repo-1/labels{/name}",</li>
///         <li>
///             "releases_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/releases{/id}",
///         </li>
///         <li>
///             "deployments_url" :
///             "https://api.github.com/repos/octocat/boysenberry-repo-1/deployments",
///         </li>
///         <li>"created_at" : "2018-05-10T17:51:29Z",</li>
///         <li>"updated_at" : "2025-11-17T10:32:38Z",</li>
///         <li>"pushed_at" : "2024-05-26T07:02:05Z",</li>
///         <li>"git_url" : "git://github.com/octocat/boysenberry-repo-1.git",</li>
///         <li>"ssh_url" : "git@github.com:octocat/boysenberry-repo-1.git",</li>
///         <li>"clone_url" : "https://github.com/octocat/boysenberry-repo-1.git",</li>
///         <li>"svn_url" : "https://github.com/octocat/boysenberry-repo-1",</li>
///         <li>"homepage" : "",</li>
///         <li>"size" : 4,</li>
///         <li>"stargazers_count" : 388,</li>
///         <li>"watchers_count" : 388,</li>
///         <li>"language" : null,</li>
///         <li>"has_issues" : false,</li>
///         <li>"has_projects" : true,</li>
///         <li>"has_downloads" : true,</li>
///         <li>"has_wiki" : true,</li>
///         <li>"has_pages" : false,</li>
///         <li>"has_discussions" : false,</li>
///         <li>"forks_count" : 26,</li>
///         <li>"mirror_url" : null,</li>
///         <li>"archived" : false,</li>
///         <li>"disabled" : false,</li>
///         <li>"open_issues_count" : 1,</li>
///         <li>"license" : null,</li>
///         <li>"allow_forking" : true,</li>
///         <li>"is_template" : false,</li>
///         <li>"web_commit_signoff_required" : false,</li>
///         <li>"topics" : [ ],</li>
///         <li>"visibility" : "public",</li>
///         <li>"forks" : 26,</li>
///         <li>"open_issues" : 1,</li>
///         <li>"watchers" : 388,</li>
///         <li>"default_branch" : "master"</li>
///     </ul>
/// </summary>
public class Repository {
    [JsonPropertyName("id")] public ulong Id { get; set; }
    [JsonPropertyName("node_id")] public string NodeId { get; set; } = default!;
    [JsonPropertyName("name")] public string Name { get; set; } = default!;

    [JsonPropertyName("full_name")]
    public string FullName { get; set; } = default!;

    [JsonPropertyName("private")] public bool Private { get; set; }
    [JsonPropertyName("owner")] public RepositoryOwner Owner { get; set; } = default!;
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = default!;
    [JsonPropertyName("description")] public string? Description { get; set; }
    [JsonPropertyName("fork")] public bool Fork { get; set; }
    [JsonPropertyName("url")] public string Url { get; set; } = default!;
    [JsonPropertyName("forks_url")] public string ForksUrl { get; set; } = default!;
    [JsonPropertyName("keys_url")] public string KeysUrl { get; set; } = default!;
    [JsonPropertyName("collaborators_url")] public string CollaboratorsUrl { get; set; } = default!;
    [JsonPropertyName("teams_url")] public string TeamsUrl { get; set; } = default!;
    [JsonPropertyName("hooks_url")] public string HooksUrl { get; set; } = default!;
    [JsonPropertyName("issue_events_url")] public string IssueEventsUrl { get; set; } = default!;
    [JsonPropertyName("events_url")] public string EventsUrl { get; set; } = default!;
    [JsonPropertyName("assignees_url")] public string AssigneesUrl { get; set; } = default!;
    [JsonPropertyName("branches_url")] public string BranchesUrl { get; set; } = default!;
    [JsonPropertyName("tags_url")] public string TagsUrl { get; set; } = default!;
    [JsonPropertyName("blobs_url")] public string BlobsUrl { get; set; } = default!;
    [JsonPropertyName("git_tags_url")] public string GitTagsUrl { get; set; } = default!;
    [JsonPropertyName("git_refs_url")] public string GitRefsUrl { get; set; } = default!;
    [JsonPropertyName("trees_url")] public string TreesUrl { get; set; } = default!;
    [JsonPropertyName("statuses_url")] public string StatusesUrl { get; set; } = default!;
    [JsonPropertyName("languages_url")] public string LanguagesUrl { get; set; } = default!;
    [JsonPropertyName("stargazers_url")] public string StargazersUrl { get; set; } = default!;
    [JsonPropertyName("contributors_url")] public string ContributorsUrl { get; set; } = default!;
    [JsonPropertyName("subscribers_url")] public string SubscribersUrl { get; set; } = default!;
    [JsonPropertyName("subscription_url")] public string SubscriptionUrl { get; set; } = default!;
    [JsonPropertyName("commits_url")] public string CommitsUrl { get; set; } = default!;
    [JsonPropertyName("git_commits_url")] public string GitCommitsUrl { get; set; } = default!;
    [JsonPropertyName("comments_url")] public string CommentsUrl { get; set; } = default!;
    [JsonPropertyName("issue_comment_url")] public string IssueCommentUrl { get; set; } = default!;
    [JsonPropertyName("contents_url")] public string ContentsUrl { get; set; } = default!;
    [JsonPropertyName("compare_url")] public string CompareUrl { get; set; } = default!;
    [JsonPropertyName("merges_url")] public string MergesUrl { get; set; } = default!;
    [JsonPropertyName("archive_url")] public string ArchiveUrl { get; set; } = default!;
    [JsonPropertyName("downloads_url")] public string DownloadsUrl { get; set; } = default!;
    [JsonPropertyName("issues_url")] public string IssuesUrl { get; set; } = default!;
    [JsonPropertyName("pulls_url")] public string PullsUrl { get; set; } = default!;
    [JsonPropertyName("milestones_url")] public string MilestonesUrl { get; set; } = default!;
    [JsonPropertyName("notifications_url")] public string NotificationsUrl { get; set; } = default!;
    [JsonPropertyName("labels_url")] public string LabelsUrl { get; set; } = default!;
    [JsonPropertyName("releases_url")] public string ReleasesUrl { get; set; } = default!;
    [JsonPropertyName("deployments_url")] public string DeploymentsUrl { get; set; } = default!;
    [JsonPropertyName("created_at")] public string CreatedAt { get; set; } = default!;
    [JsonPropertyName("updated_at")] public string UpdatedAt { get; set; } = default!;
    [JsonPropertyName("pushed_at")] public string PushedAt { get; set; } = default!;
    [JsonPropertyName("git_url")] public string GitUrl { get; set; } = default!;
    [JsonPropertyName("ssh_url")] public string SshUrl { get; set; } = default!;
    [JsonPropertyName("clone_url")] public string CloneUrl { get; set; } = default!;
    [JsonPropertyName("svn_url")] public string SvnUrl { get; set; } = default!;
    [JsonPropertyName("homepage")] public string? Homepage { get; set; }
    [JsonPropertyName("size")] public ulong Size { get; set; }
    [JsonPropertyName("stargazers_count")] public uint StargazersCount { get; set; }
    [JsonPropertyName("watchers_count")] public uint WatchersCount { get; set; }
    [JsonPropertyName("language")] public string? Language { get; set; }
    [JsonPropertyName("has_issues")] public bool HasIssues { get; set; }
    [JsonPropertyName("has_projects")] public bool HasProjects { get; set; }
    [JsonPropertyName("has_downloads")] public bool HasDownloads { get; set; }
    [JsonPropertyName("has_wiki")] public bool HasWiki { get; set; }
    [JsonPropertyName("has_pages")] public bool HasPages { get; set; }
    [JsonPropertyName("has_discussions")] public bool HasDiscussions { get; set; }
    [JsonPropertyName("forks_count")] public uint ForksCount { get; set; }
    [JsonPropertyName("mirror_url")] public string? MirrorUrl { get; set; }
    [JsonPropertyName("archived")] public bool Archived { get; set; }
    [JsonPropertyName("disabled")] public bool Disabled { get; set; }
    [JsonPropertyName("open_issue_count")] public uint OpenIssuesCount { get; set; }
    [JsonPropertyName("license")] public object? License { get; set; }
    [JsonPropertyName("allow_forking")] public bool AllowForking { get; set; }
    [JsonPropertyName("is_template")] public bool IsTemplate { get; set; }
    [JsonPropertyName("web_commit_signoff_required")] public bool WebCommitSignoffRequired { get; set; }
    [JsonPropertyName("topics")] public List<string> Topics { get; set; } = new();
    [JsonPropertyName("visibility")] public string Visibility { get; set; } = default!;
    [JsonPropertyName("forks")] public uint Forks { get; set; }
    [JsonPropertyName("open_issues")] public uint OpenIssues { get; set; }
    [JsonPropertyName("watchers")] public uint Watchers { get; set; }
    [JsonPropertyName("default_branch")] public string DefaultBranch { get; set; } = default!;
}

/// <summary>
///     Example Owner Object:
///     <p>
///         <ul>
///             <li>"login" : "octocat",</li>
///             <li>"id" : 583231,</li>
///             <li>"node_id" : "MDQ6VXNlcjU4MzIzMQ==",</li>
///             <li>"avatar_url" : "https://avatars.githubusercontent.com/u/583231?v=4",</li>
///             <li>"gravatar_id" : "",</li>
///             <li>"url" : "https://api.github.com/users/octocat",</li>
///             <li>"html_url" : "https://github.com/octocat",</li>
///             <li>"followers_url" : "https://api.github.com/users/octocat/followers",</li>
///             <li>"following_url" : "https://api.github.com/users/octocat/following{/other_user}",</li>
///             <li>"gists_url" : "https://api.github.com/users/octocat/gists{/gist_id}",</li>
///             <li>"starred_url" : "https://api.github.com/users/octocat/starred{/owner}{/repo}",</li>
///             <li>"subscriptions_url" : "https://api.github.com/users/octocat/subscriptions",</li>
///             <li>"organizations_url" : "https://api.github.com/users/octocat/orgs",</li>
///             <li>"repos_url" : "https://api.github.com/users/octocat/repos",</li>
///             <li>"events_url" : "https://api.github.com/users/octocat/events{/privacy}",</li>
///             <li>"received_events_url" : "https://api.github.com/users/octocat/received_events",</li>
///             <li>"type" : "User",</li>
///             <li>"user_view_type" : "public",</li>
///             <li>"site_admin" : false</li>
///         </ul>
///     </p>
/// </summary>
public class RepositoryOwner {
    [JsonPropertyName("login")]
    public string Login { get; set; } = default!;

    [JsonPropertyName("id")]
    public ulong Id { get; set; }

    [JsonPropertyName("node_id")]
    public string NodeId { get; set; } = default!;

    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; } = default!;

    [JsonPropertyName("gravatar_id")]
    public string? GravatarId { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; } = default!;

    [JsonPropertyName("html_url")]
    public string HtmlUrl { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("site_admin")]
    public bool SiteAdmin { get; set; }
}

public class Branch {
}
