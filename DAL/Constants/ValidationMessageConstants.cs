namespace DAL.Constants;

/// <summary>
/// This class contains constants for validation messages used in the application.
/// </summary>
internal static class ValidationMessageConstants
{
    /// <summary>
    /// Validation message for first name to contain only letters.
    /// </summary>
    public const string UserFirstNameOnlyLetters = "First name can only contain letters.";

    /// <summary>
    /// Validation message for last name to contain only letters.
    /// </summary>
    public const string UserLastNameOnlyLetters = "Last name can only contain letters.";

    /// <summary>
    /// Validation message for username to contain only letters, numbers, underscores, and dots.
    /// </summary>
    public const string UsernameValidation = "Username can contain only letters, numbers, underscores and dots.";

    /// <summary>
    /// Validation message for email to be a valid email address.
    /// </summary>
    public const string UserEmailValidation = "Email must be a valid email address.";

    /// <summary>
    /// Validation message for password to meet security requirements.
    /// </summary>
    public const string UserPasswordValidation = "Password must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number.";
}
