using FluentResults;

namespace Domain.ResultPattern;

public class ApplicationError : IError
{
    public List<IError> Reasons { get; private set; } = new();

    public string Message { get; private set; } = string.Empty;

    public Dictionary<string, object> Metadata { get; private set; } = new();

    public StatusCode StatusCode { get; private set; } = StatusCode.NotSpecified;

    public ApplicationError(string message, StatusCode statusCode)
    {
        this.Message = message;
        this.StatusCode = statusCode;
    }

    public static ApplicationError NotFound(string message = "Not found")
    {
        return new ApplicationError(message, StatusCode.NotFound);
    }

    public static ApplicationError BadRequest(string message = "Bad request")
    {
        return new ApplicationError(message, StatusCode.BadRequest);
    }
}
