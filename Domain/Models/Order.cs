namespace Domain.Models;

/// <summary>
/// Represents an order in the e-commerce system.
/// </summary>
public class Order
{
    /// <summary>
    /// Gets or sets the unique identifier for the order.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the customer identifier associated with the order.
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the order was placed.
    /// </summary>
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the total amount of the order before any discounts are applied.
    /// </summary>
    public decimal TotalAmountWithoutDiscount { get; set; }

    /// <summary>
    /// Gets or sets the discount amount applied to the order.
    /// </summary>
    public decimal DiscountAmount { get; set; }

    /// <summary>
    /// Gets or sets the status of the order (e.g., Pending, Shipped, Delivered).
    /// </summary>
    public decimal TotalAmount => this.TotalAmountWithoutDiscount - this.DiscountAmount;

    /// <summary>
    /// Gets or sets the status of the order.
    /// </summary>
    public OrderStatus Status { get; set; } = OrderStatus.None;

    /// <summary>
    /// Returns a string representation of the order, including its properties.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"Order:\n" +
               $"Id: {this.Id}\n" +
               $"CustomerId: {this.CustomerId}\n" +
               $"OrderDate: {this.OrderDate}\n" +
               $"TotalAmountWithoutDiscount: {this.TotalAmountWithoutDiscount}\n" +
               $"DiscountAmount: {this.DiscountAmount}\n" +
               $"TotalAmount: {this.TotalAmount}\n" +
               $"Status: {this.Status}\n";
    }

    /// <summary>
    /// Checks if the current order is equal to another order based on its properties.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is Order order)
        {
            return this.Id == order.Id &&
                   this.CustomerId == order.CustomerId &&
                   this.OrderDate == order.OrderDate &&
                   this.TotalAmountWithoutDiscount == order.TotalAmountWithoutDiscount &&
                   this.DiscountAmount == order.DiscountAmount &&
                   this.Status == order.Status;
        }
        return false;
    }

    /// <summary>
    /// Generates a hash code for the order based on its properties.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(this.Id, this.CustomerId, this.OrderDate, this.TotalAmountWithoutDiscount, this.DiscountAmount, this.Status);
    }
}
