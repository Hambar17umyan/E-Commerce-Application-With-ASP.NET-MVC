using Domain.Models.Abstract;

namespace Domain.Models.Concrete;

public class User : DomainModel
{
    /// <summary>
    /// Gets or sets the first name of the user.
    /// </summary>
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the last name of the user.
    /// </summary>
    public string LastName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the date of birth of the user.
    /// </summary>
    public DateOnly DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the unique username for the user.
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the email address of the user.
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the hashed password of the user.
    /// </summary>
    public string PasswordHash { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the role of the user, which defines their permissions and access levels.
    /// </summary>
    public UserRole Role { get; set; } = new UserRole();

    /// <summary>
    /// Gets or sets the date and time when the user was created.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the date and time when the user was last updated.
    /// </summary>
    public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the shopping cart associated with the user, which contains items they intend to purchase.
    /// </summary>
    public Cart Cart { get; set; } = new Cart();

    /// <summary>
    /// Initializes a new instance of the <see cref="User"/> class with default values.
    /// </summary>
    public User() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="User"/> class with specified values.
    /// </summary>
    /// <param name="id">The user id.</param>
    /// <param name="username">The user username.</param>
    /// <param name="email">The user Email.</param>
    /// <param name="passwordHash">The hash of user password.</param>
    /// <param name="role">The user role.</param>
    public User(int id, string username, string email, string passwordHash, UserRole role)
    {
        this.Id = id;
        this.Username = username;
        this.Email = email;
        this.PasswordHash = passwordHash;
        this.Role = role;
    }

    /// <summary>
    /// Returns a string representation of the User object, including its properties.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"User:\n" +
            $"Id: {this.Id}\n" +
            $"First name: {this.FirstName}\n" +
            $"Last name: {this.LastName}\n" +
            $"Date of Birth: {this.DateOfBirth}\n" +
            $"Username: {this.Username}\n" +
            $"Email: {this.Email}\n" +
            $"Role Id: {this.Role.Id}\n" +
            $"Created At: {this.CreatedAt}\n" +
            $"Last Updated At: {this.LastUpdatedAt}";
    }

    /// <summary>
    /// Checks if the current User object is equal to another object.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        if (obj is User user)
        {
            return this.Id == user.Id &&
                   this.Username == user.Username &&
                   this.Email == user.Email &&
                   this.PasswordHash == user.PasswordHash &&
                   this.Role.Id == user.Role.Id;
        }
        return false;
    }

    /// <summary>
    /// Returns a hash code for the current User object based on its properties.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
