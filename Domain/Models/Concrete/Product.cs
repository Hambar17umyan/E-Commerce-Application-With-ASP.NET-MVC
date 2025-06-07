using Domain.Models.Abstract;

namespace Domain.Models.Concrete;

/// <summary>
/// Represents a product in the e-commerce system.
/// </summary>
public class Product : DomainModel
{
    /// <summary>
    /// Gets or sets the name of the product.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description of the product.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the category identifier to which the product belongs.
    /// </summary>
    public Category Category { get; set; } = new Category();

    /// <summary>
    /// Gets or sets the price of the product.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the stock quantity available for the product.
    /// </summary>
    public int StockQuantity { get; set; }

    /// <summary>
    /// Gets or sets the indicates whether the product is active or not.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the indicates the last time the product was updated.
    /// </summary>
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Returns a string representation of the product, including its properties.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"Product:\n" +
               $"Id: {this.Id}\n" +
               $"Name: {this.Name}\n" +
               $"Description: {this.Description}\n" +
               $"Category: {this.Category.Name}\n" +
               $"Price: {this.Price}\n" +
               $"Stock Quantity: {this.StockQuantity}\n" +
               $"Created At: {this.CreatedAt}\n" +
               $"Updated At: {this.UpdatedAt}\n";
    }

    /// <summary>
    /// Checks if the current product is equal to another product based on its properties.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is Product product)
        {
            return this.Id == product.Id &&
                   this.Name == product.Name &&
                   this.Description == product.Description &&
                   this.Category.Id == product.Category.Id &&
                   this.Price == product.Price &&
                   this.StockQuantity == product.StockQuantity &&
                   this.CreatedAt == product.CreatedAt &&
                   this.UpdatedAt == product.UpdatedAt;
        }
        return false;
    }

    /// <summary>
    /// Generates a hash code for the product based on its properties.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
