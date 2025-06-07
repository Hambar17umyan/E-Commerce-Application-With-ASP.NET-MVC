using DAL.Constants;
using DAL.Constants.ColumnNameConstants;
using DAL.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Concrete;

/// <summary>
/// Represents an item in a shopping cart.
/// </summary>
[Table(TableNameConstants.CartItem)]
public class CartItemEntity : IDbEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the cart item.
    /// </summary>
    [Key]
    [Required]
    [Column(CartItemColumnNameConstants.Id)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the cart to which this item belongs.
    /// </summary>
    [Required]
    [Column(CartItemColumnNameConstants.CartId)]
    [ForeignKey(nameof(this.Cart))]
    public int CartId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the product associated with this cart item.
    /// </summary>
    [Required]
    [Column(CartItemColumnNameConstants.ProductId)]
    [ForeignKey(nameof(this.Product))]
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the product in the cart item.
    /// </summary>
    [Required]
    [Column(CartItemColumnNameConstants.Quantity)]
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the price of the product in the cart item.
    /// </summary>
    [Required]
    [Column(CartItemColumnNameConstants.Price)]
    public decimal Price { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the cart item was added to the cart.
    /// </summary>
    [Required]
    [Column(CartItemColumnNameConstants.AddedAt)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    [DataType(DataType.DateTime)]
    public DateTime AddedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the date and time when the cart item was last updated.
    /// </summary>
    [Column(CartItemColumnNameConstants.LastUpdatedAt)]
    [DataType(DataType.DateTime)]
    public DateTime? LastUpdatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the cart to which this item belongs.
    /// </summary>
    public CartEntity? Cart { get; set; }

    /// <summary>
    /// Gets or sets the product associated with this cart item.
    /// </summary>

    public ProductEntity? Product { get; set; }
}
