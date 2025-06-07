namespace DAL.Constants.ColumnNameConstants;

/// <summary>
/// This class contains constants for user-related column names in the database.
/// </summary>
internal static class UserColumnNameConstants
{
    /// <summary>
    /// The column name for the unique identifier of the user entity.
    /// </summary>
    public const string Id = "user_id";

    /// <summary>
    /// The column name for the first name of the user.
    /// </summary>
    public const string FirstName = "user_firstName";

    /// <summary>
    /// The column name for the last name of the user.
    /// </summary>
    public const string LastName = "user_lastName";

    /// <summary>
    /// The column name for the date of birth of the user.
    /// </summary>
    public const string DateOfBirth = "user_dateOfBirth";

    /// <summary>
    /// The column names for the user entity in the database.
    /// </summary>
    public const string Username = "user_username";

    /// <summary>
    /// The column name for the email address of the user.
    /// </summary>
    public const string Email = "user_email";

    /// <summary>
    /// The column name for the password hash of the user.
    /// </summary>
    public const string PasswordHash = "user_passwordHash";

    /// <summary>
    /// The column name for the created at timestamp of the user.
    /// </summary>
    public const string CreatedAt = "user_createdAt";

    /// <summary>
    /// The column name for the last updated timestamp of the user.
    /// </summary>
    public const string LastUpdatedAt = "user_lastUpdatedAt";

    /// <summary>
    /// The column name for the role ID of the user, which is a foreign key reference to the UserRole entity.
    /// </summary>
    public const string RoleId = "user_roleId";

    /// <summary>
    /// The column name for the cart ID of the user, which is a foreign key reference to the Cart entity.
    /// </summary>
    public const string CartId = "user_cartId";
}
