using Domain.Models.Abstract;

namespace Domain.Models.Concrete;

/// <summary>
/// Represents an item in an order, typically containing details about the product, quantity, and price.
/// </summary>
public class OrderItem : DomainModel
{
    /// <summary>
    /// Gets or sets the order to which this item belongs.
    /// </summary>
    public Order Order { get; set; } = new Order();

    /// <summary>
    /// Gets or sets the product associated with this order item.
    /// </summary>
    public Product Product { get; set; } = new Product();

    /// <summary>
    /// Gets or sets the quantity of the product ordered.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the price of the product at the time of ordering.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Returns a string representation of the OrderItem object, including its properties.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"OrderItem:\n" +
            $"Id: {this.Id}\n" +
            $"Order Id: {this.Order.Id}" +
            $"Product: {this.Product.Name}" +
            $"Quantity: {this.Quantity}" +
            $"Price: {this.Price}";
    }

    /// <summary>
    /// Determines whether the specified object is equal to the current OrderItem object.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is OrderItem other)
        {
            return this.Id == other.Id &&
                   this.Order.Id == other.Order.Id &&
                   this.Product.Id == other.Product.Id &&
                   this.Quantity == other.Quantity &&
                   this.Price == other.Price;
        }
        return false;
    }

    /// <summary>
    /// Returns a hash code for the current OrderItem object.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}