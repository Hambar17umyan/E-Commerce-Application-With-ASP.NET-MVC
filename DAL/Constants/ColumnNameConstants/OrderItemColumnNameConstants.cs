namespace DAL.Constants.ColumnNameConstants;

internal static class OrderItemColumnNameConstants
{
    /// <summary>
    /// The name of the column representing the unique identifier for the order item.
    /// </summary>
    public const string Id = "order_item_id";

    /// <summary>
    /// The name of the column representing the unique identifier for the order to which this item belongs.
    /// </summary>
    public const string OrderId = "order_item_orderId";

    /// <summary>
    /// The name of the column representing the unique identifier for the product associated with this order item.
    /// </summary>
    public const string ProductId = "order_item_productId";

    /// <summary>
    /// The name of the column representing the quantity of the product ordered.
    /// </summary>
    public const string Quantity = "order_item_quantity";

    /// <summary>
    /// The name of the column representing the price of the product at the time of ordering.
    /// </summary>
    public const string Price = "order_item_price";
}
