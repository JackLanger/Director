namespace Director.Core;

public interface IGithubAuthenticator {
    string Token { get;  }
    string Authenticate(string user);
}
