using Domain.Models.Abstract;

namespace Domain.Models.Concrete;

/// <summary>
/// Represents an item in a shopping cart.
/// </summary>
public class CartItem : DomainModel
{
    /// <summary>
    /// Gets or sets the name of the product associated with this cart item.
    /// </summary>
    public string ProductName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the quantity of the product in the cart item.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the price of the product in the cart item.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the cart item was added to the cart.
    /// </summary>
    public DateTime AddedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the date and time when the cart item was last updated.
    /// </summary>
    public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the shopping cart associated with the cart item, which contains items the user intends to purchase.
    /// </summary>
    public Cart Cart { get; set; } = new Cart();

    /// <summary>
    /// Gets or sets the product associated with this cart item.
    /// </summary>
    public Product Product { get; set; } = new Product();

    /// <summary>
    /// Initializes a new instance of the <see cref="CartItem"/> class with default values.
    /// </summary>
    public CartItem() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="CartItem"/> class with specified values.
    /// </summary>
    /// <param name="id">Cart item id.</param>
    /// <param name="cartId">Cart item cart id.</param>
    /// <param name="productId">Cart item product id.</param>
    /// <param name="productName">Cart item product name.</param>
    /// <param name="quantity">Cart item product quantity.</param>
    /// <param name="price">Cart item overall price.</param>
    public CartItem(int id, Cart cart, Product product, string productName, int quantity, decimal price)
    {
        this.Id = id;
        this.Cart = cart;
        this.ProductName = productName;
        this.Product = product;
        this.Quantity = quantity;
        this.Price = price;
    }

    /// <summary>
    /// Returns a string representation of the cart item, including its properties.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"CartItem:\n" +
               $"Id: {this.Id}\n" +
               $"CartId: {this.Cart.Id}\n" +
               $"Product name: {this.Product.Name}\n" +
               $"ProductName: {this.ProductName}\n" +
               $"Quantity: {this.Quantity}\n" +
               $"Price: {this.Price}\n" +
               $"AddedAt: {this.AddedAt}\n" +
               $"LastUpdatedAt: {this.LastUpdatedAt}\n";
    }

    /// <summary>
    /// Checks if the current cart item is equal to another cart item based on its properties.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is not CartItem other)
            return false;
        return this.Id == other.Id &&
               this.Cart.Id == other.Cart.Id &&
               this.Product.Id == other.Product.Id &&
               this.ProductName == other.ProductName &&
               this.Quantity == other.Quantity &&
               this.Price == other.Price &&
               this.AddedAt == other.AddedAt &&
               this.LastUpdatedAt == other.LastUpdatedAt;
    }

    /// <summary>
    /// Returns a hash code for the current cart item based on its properties.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
