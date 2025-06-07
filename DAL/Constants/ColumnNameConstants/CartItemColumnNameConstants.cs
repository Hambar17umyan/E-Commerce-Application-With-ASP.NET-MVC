namespace DAL.Constants.ColumnNameConstants;

internal static class CartItemColumnNameConstants
{
    /// <summary>
    /// The name of the column representing the unique identifier for the cart item.
    /// </summary>
    public const string Id = "cart_item_id";

    /// <summary>
    /// The name of the column representing the identifier for the cart to which this item belongs.
    /// </summary>
    public const string CartId = "cart_item_cartId";

    /// <summary>
    /// The name of the column representing the identifier for the product associated with this cart item.
    /// </summary>
    public const string ProductId = "cart_item_productId";

    /// <summary>
    /// The name of the column representing the name of the product associated with this cart item.
    /// </summary>
    public const string ProductName = "cart_item_productName";

    /// <summary>
    /// The name of the column representing the quantity of the product in the cart item.
    /// </summary>
    public const string Quantity = "cart_item_quantity";

    /// <summary>
    /// The name of the column representing the price of the product in the cart item.
    /// </summary>
    public const string Price = "cart_item_price";

    /// <summary>
    /// The name of the column representing when this cart item was added to the cart.
    /// </summary>
    public const string AddedAt = "cart_item_addedAt";

    /// <summary>
    /// The name of the column representing when this cart item was last updated.
    /// </summary>
    public const string LastUpdatedAt = "cart_item_updatedAt";
}
