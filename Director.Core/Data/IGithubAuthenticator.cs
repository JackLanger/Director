namespace Director.Core.Data;

public interface IGithubAuthenticator : IAuthenticationService {
    string Token { get; }
    string Authenticate(string user);
}
