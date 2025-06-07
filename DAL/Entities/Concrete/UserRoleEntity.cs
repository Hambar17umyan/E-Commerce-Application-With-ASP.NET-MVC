using DAL.Constants;
using DAL.Constants.ColumnNameConstants;
using DAL.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Concrete;

[Table(TableNameConstants.UserRole)]
public class UserRoleEntity : IDbEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the user role entity.
    /// </summary>
    [Key]
    [Required]
    [Column(UserRoleColumnNameConstants.Id)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the user role entity.
    /// </summary>
    [Required]
    [Column(UserRoleColumnNameConstants.Name)]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the user role entity.
    /// </summary>
    [Column(UserRoleColumnNameConstants.Description)]
    public string? Description { get; set; }
}
