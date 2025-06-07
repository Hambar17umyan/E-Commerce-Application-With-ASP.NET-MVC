namespace Domain.Models;

/// <summary>
/// Represents a user role in the e-commerce system.
/// </summary>
public class UserRole
{
    /// <summary>
    /// Gets or sets the unique identifier for the user role.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the user role.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the user role.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UserRole"/> class with default values.
    /// </summary>
    public UserRole()
    {
        this.Id = 0;
        this.Name = string.Empty;
        this.Description = string.Empty;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="UserRole"/> class with specified values.
    /// </summary>
    /// <param name="id">The user role id.</param>
    /// <param name="name">The user role name.</param>
    /// <param name="description">The user role description.</param>
    public UserRole(int id, string name, string description)
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;
    }

    /// <summary>
    /// Returns a string representation of the user role, including its properties.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"UserRole:\n" +
            $"Id: {this.Id}\n" +
            $"Name: {this.Name}\n" +
            $"Description: {this.Description}\n";
    }

    /// <summary>
    /// Returns a bool indicating if the current instance is equal to another object instance based on Id, Name, and Description.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is UserRole role &&
               this.Id == role.Id &&
               this.Name == role.Name &&
               this.Description == role.Description;
    }

    /// <summary>
    /// Returns a hash code for the current instance based on Id, Name, and Description.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(this.Id, this.Name, this.Description);
    }
}
