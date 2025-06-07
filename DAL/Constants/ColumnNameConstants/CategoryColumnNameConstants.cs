namespace DAL.Constants.ColumnNameConstants;

/// <summary>
/// This class contains constants for category-related column names in the database.
/// </summary>
internal static class CategoryColumnNameConstants
{
    /// <summary>
    /// The column name for the unique identifier of the category entity.
    /// </summary>
    public const string Id = "category_id";

    /// <summary>
    /// The column name for the name of the category.
    /// </summary>
    public const string Name = "category_name";

    /// <summary>
    /// The column name for the description of the category.
    /// </summary>
    public const string Description = "category_description";

    /// <summary>
    /// The column name for the date and time when the category was created.
    /// </summary>
    public const string CreatedAt = "category_createdAt";

    /// <summary>
    /// The column name for the date and time when the category was last updated.
    /// </summary>
    public const string LastUpdatedAt = "category_lastUpdatedAt";
}
