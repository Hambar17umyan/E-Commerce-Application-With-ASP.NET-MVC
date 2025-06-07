using DAL.Constants.ColumnNameConstants;
using DAL.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Concrete;

/// <summary>
/// Represents a product entity in the e-commerce system.
/// </summary>
public class ProductEntity : IDbEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the product.
    /// </summary>
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(ProductColumnNameConstants.Id)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the product.
    /// </summary>
    [Required]
    [Column(ProductColumnNameConstants.Name)]
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the product.
    /// </summary>
    [Column(ProductColumnNameConstants.Description)]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets the category to which the product belongs.
    /// </summary>
    public CategoryEntity? Category { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the category of the product.
    /// </summary>
    [ForeignKey(nameof(Category))]
    [Column(ProductColumnNameConstants.CategoryId)]
    [Required]
    public int CategoryId { get; set; }

    /// <summary>
    /// Gets or sets the price of the product.
    /// </summary>
    [Required]
    [Column(ProductColumnNameConstants.Price)]
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the stock quantity available for the product.
    /// </summary>
    [Required]
    [Column(ProductColumnNameConstants.StockQuantity)]
    public int StockQuantity { get; set; }

    /// <summary>
    /// Gets or sets the indicates whether the product is active or not.
    /// </summary>
    [Column(ProductColumnNameConstants.CreatedAt)]
    [Required]
    [DataType(DataType.DateTime)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the indicates the last time the product was updated.
    /// </summary>
    [Column(ProductColumnNameConstants.UpdatedAt)]
    [DataType(DataType.DateTime)]
    public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
}
