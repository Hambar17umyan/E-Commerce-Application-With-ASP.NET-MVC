namespace Domain.ResultPattern;

public enum StatusCode
{
    NotSpecified = 0,
    Success = 200,
    BadRequest = 400,
    Unauthorized = 401,
    Forbidden = 403,
    NotFound = 404,
    Conflict = 409,
}
