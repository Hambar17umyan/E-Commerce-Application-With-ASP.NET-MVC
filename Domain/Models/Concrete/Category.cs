using Domain.Models.Abstract;

namespace Domain.Models.Concrete;

/// <summary>
/// Represents a category in the e-commerce system.
/// </summary>
public class Category : DomainModel
{
    /// <summary>
    /// Gets or sets the name of the category.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description of the category.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the date and time when the category was created.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the date and time when the category was last updated.
    /// </summary>
    public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Initializes a new instance of the <see cref="Category"/> class with default values.
    /// </summary>
    public Category() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Category"/> class with specified values.
    /// </summary>
    /// <param name="id">The category id.</param>
    /// <param name="name">The category name.</param>
    /// <param name="description">The category description.</param>
    public Category(int id, string name, string description)
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;
    }

    /// <summary>
    /// Returns a string representation of the category, including its properties.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"Category:\n" +
               $"Id: {this.Id}\n" +
               $"Name: {this.Name}\n" +
               $"Description: {this.Description}\n" +
               $"CreatedAt: {this.CreatedAt}\n" +
               $"LastUpdatedAt: {this.LastUpdatedAt}\n";
    }

    /// <summary>
    /// Checks if the current category is equal to another category based on its properties.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is not Category other)
        {
            return false;
        }
        return this.Id == other.Id &&
               this.Name == other.Name &&
               this.Description == other.Description &&
               this.CreatedAt == other.CreatedAt &&
               this.LastUpdatedAt == other.LastUpdatedAt;
    }

    /// <summary>
    /// Generates a hash code for the current category based on its properties.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
