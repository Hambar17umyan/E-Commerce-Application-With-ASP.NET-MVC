namespace DAL.Constants;

/// <summary>
/// This class contains constants for regular expression patterns used in the application.
/// </summary>
internal static class RegexPatternConstants
{
    /// <summary>
    /// Pattern to match only letters (uppercase and lowercase).
    /// </summary>
    public const string OnlyLetters = @"^[a-zA-Z]+$";

    /// <summary>
    /// Pattern to match only letters (uppercase and lowercase), numbers, dots, and underscores.
    /// </summary>
    public const string OnlyLettersNumbersDotUnderscore = @"^[a-zA-Z0-9_.]+$";

    /// <summary>
    /// Pattern to match a valid email address format.
    /// </summary>
    public const string StrongPassword = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";
}
