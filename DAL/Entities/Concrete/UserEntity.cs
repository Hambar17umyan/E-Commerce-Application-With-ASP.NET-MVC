using DAL.Constants;
using DAL.Constants.ColumnNameConstants;
using DAL.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Concrete;

[Table(TableNameConstants.User)]
public class UserEntity : IDbEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the User entity.
    /// </summary>
    [Key]
    [Required]
    [Column(UserColumnNameConstants.Id)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the first name of the user.
    /// </summary>
    [Required]
    [Column(UserColumnNameConstants.FirstName)]
    [RegularExpression(RegexPatternConstants.OnlyLetters, 
        ErrorMessage = ValidationMessageConstants.UserFirstNameOnlyLetters)]
    public string? FirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name of the user.
    /// </summary>
    [Required]
    [Column(UserColumnNameConstants.LastName)]
    [RegularExpression(RegexPatternConstants.OnlyLetters, 
        ErrorMessage = ValidationMessageConstants.UserLastNameOnlyLetters)]
    public string? LastName { get; set; }

    /// <summary>
    /// Gets or sets the date of birth of the user.
    /// </summary>
    [Column(UserColumnNameConstants.DateOfBirth)]
    [Required]
    [DataType(DataType.Date)]
    public DateOnly? DateOfBirth { get; set; }

    /// <summary>
    /// Gets or sets the unique username for the user.
    /// </summary>
    [Required]
    [Column(UserColumnNameConstants.Username)]
    [RegularExpression( RegexPatternConstants.OnlyLettersNumbersDotUnderscore,
        ErrorMessage =ValidationMessageConstants.UsernameValidation)]
    public string? Username { get; set; }

    /// <summary>
    /// Gets or sets the email address of the user.
    /// </summary>
    [Required]
    [Column(UserColumnNameConstants.Email)]
    [EmailAddress(ErrorMessage = ValidationMessageConstants.UserEmailValidation)]
    public string? Email { get; set; }

    /// <summary>
    /// Gets or sets the hashed password of the user.
    /// </summary>
    [Required]
    [Column(UserColumnNameConstants.PasswordHash)]
    [RegularExpression(RegexPatternConstants.StrongPassword,
        ErrorMessage = ValidationMessageConstants.UserPasswordValidation)]
    public string? PasswordHash { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the user was created.
    /// </summary>
    [Column(UserColumnNameConstants.CreatedAt)]
    [Required]
    [DataType(DataType.DateTime)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the user was last updated.
    /// </summary>
    [Column(UserColumnNameConstants.LastUpdatedAt)]
    [Required]
    [DataType(DataType.DateTime)]
    public DateTime? LastUpdatedAt { get; set; }

    [ForeignKey(nameof(Cart))]
    [Column(UserColumnNameConstants.CartId)]
    [Required]
    public int CartId { get; set; }

    [ForeignKey(nameof(Role))]
    [Column(UserColumnNameConstants.RoleId)]
    [Required]
    public int RoleId { get; set; }

    /// <summary>
    /// Gets or sets the shopping cart associated with the user, which contains items they intend to purchase.
    /// </summary>
    public CartEntity? Cart { get; set; }

    /// <summary>
    /// Gets or sets the role of the user, which defines their permissions and access levels.
    /// </summary>
    public UserRoleEntity? Role { get; set; }
}
