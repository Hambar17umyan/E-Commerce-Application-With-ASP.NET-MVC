namespace DAL.Constants.ColumnNameConstants;

/// <summary>
/// Defines constants for the column names used in the Product entity.
/// </summary>
internal class ProductColumnNameConstants
{
    /// <summary>
    /// The name of the column representing the unique identifier for the product.
    /// </summary>
    public const string Id = "product_id";

    /// <summary>
    /// The name of the column representing the name of the product.
    /// </summary>
    public const string Name = "product_name";

    /// <summary>
    /// The name of the column representing the description of the product.
    /// </summary>
    public const string Description = "product_description";

    /// <summary>
    /// The name of the column representing the unique identifier for the category of the product.
    /// </summary>
    public const string CategoryId = "product_categoryId";

    /// <summary>
    /// The name of the column representing the price of the product.
    /// </summary>
    public const string Price = "product_price";

    /// <summary>
    /// The name of the column representing the stock quantity available for the product.
    /// </summary>
    public const string StockQuantity = "product_stockQuantity";

    /// <summary>
    /// The name of the column representing the date and time when the product was created.
    /// </summary>
    public const string CreatedAt = "product_createdAt";

    /// <summary>
    /// The name of the column representing the date and time when the product was last updated.
    /// </summary>
    public const string UpdatedAt = "product_updatedAt";
}
