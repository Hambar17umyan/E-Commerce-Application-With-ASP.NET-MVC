namespace DAL.Constants.ColumnNameConstants;

internal static class OrderColumnNameConstants
{
    /// <summary>
    /// The name of the column that stores the unique identifier for the order entity.
    /// </summary>
    public const string Id = "order_id";
    
    /// <summary>
    /// The name of the column that stores the user identifier associated with the order.
    /// </summary>
    public const string UserId = "order_userId";
    
    /// <summary>
    /// The name of the column that stores the date and time when the order was placed.
    /// </summary>
    public const string OrderDate = "order_Date";
    
    /// <summary>
    /// The name of the column that stores the total amount of the order before any discounts are applied.
    /// </summary>
    public const string TotalAmountWithoutDiscount = "order_totalAmountWithoutDiscount";
    
    /// <summary>
    /// The name of the column that stores the discount amount applied to the order.
    /// </summary>
    public const string DiscountAmount = "order_discountAmount";
    
    /// <summary>
    /// The name of the column that stores the status of the order.
    /// </summary>
    public const string Status = "order_status";
}
