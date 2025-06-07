using DAL.Constants;
using DAL.Constants.ColumnNameConstants;
using DAL.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Concrete;

/// <summary>
/// Represents a category entity in the database.
/// </summary>
[Table(TableNameConstants.Category)]
public class CategoryEntity : IDbEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the category.
    /// </summary>
    [Key]
    [Required]
    [Column(CategoryColumnNameConstants.Id)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the category.
    /// </summary>
    [Required]
    [Column(CategoryColumnNameConstants.Name)]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the category.
    /// </summary>
    [Column(CategoryColumnNameConstants.Description)]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the date and time when the category was created.
    /// </summary>
    [Column(CategoryColumnNameConstants.CreatedAt)]
    [Required]
    [DataType(DataType.DateTime)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the date and time when the category was last updated.
    /// </summary>
    [Column(CategoryColumnNameConstants.LastUpdatedAt)]
    [DataType(DataType.DateTime)]
    public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;
}
