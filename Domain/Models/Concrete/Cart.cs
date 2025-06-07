using Domain.Models.Abstract;

namespace Domain.Models.Concrete;

/// <summary>
/// Represents a shopping cart for a customer.
/// </summary>
public class Cart : DomainModel
{
    /// <summary>
    /// Gets or sets the user associated with the cart, representing the customer who owns the cart.
    /// </summary>
    public User User { get; set; } = new User();

    /// <summary>
    /// List of items in the cart.
    /// </summary>
    public List<CartItem> Items { get; set; } = new List<CartItem>();

    /// <summary>
    /// Calculates the total price of all items in the cart.
    /// </summary>
    public decimal TotalPrice => Items.Sum(item => item.Price * item.Quantity);

    /// <summary>
    /// Returns a string representation of the Cart object, including its properties and items.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"Cart:\n" +
               $"User: {this.User.FirstName} {this.User.LastName}\n" +
               $"TotalPrice: {this.TotalPrice:C}\n" +
               $"Items: {this.Items.Count}\n" +
               $"{string.Join("\n", Items.Select(item => item.Product.Name))}";
    }

    /// <summary>
    /// Checks if the current Cart object is equal to another Cart object based on its properties and items.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is Cart other)
        {
            return this.Id == other.Id &&
                   this.User.Id == other.User.Id;
        }
        return false;
    }

    /// <summary>
    /// Returns a hash code for the current Cart object.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
