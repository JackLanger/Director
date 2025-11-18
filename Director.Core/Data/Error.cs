using System.Net;

namespace Director.Core.Data;

public class Error(string reason, HttpStatusCode statusCode) {

    public string? GetReason()
    {
        return reason;
    }

    public HttpStatusCode GetStatusCode()
    {
        return statusCode;
    }
}
