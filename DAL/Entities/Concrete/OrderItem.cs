using DAL.Constants;
using DAL.Constants.ColumnNameConstants;
using DAL.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Concrete;

/// <summary>
/// Represents an order item entity in the e-commerce system.
/// </summary>
[Table(TableNameConstants.OrderItem)]
public class OrderItemEntity : IDbEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the order item.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    [Column(OrderItemColumnNameConstants.Id)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the order to which this item belongs.
    /// </summary>
    [ForeignKey(nameof(Order))]
    [Column(OrderItemColumnNameConstants.OrderId)]
    [Required]
    public int OrderId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the product associated with this order item.
    /// </summary>
    [ForeignKey(nameof(Product))]
    [Column(OrderItemColumnNameConstants.ProductId)]
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the order to which this item belongs.
    /// </summary>
    public OrderEntity? Order { get; set; }

    /// <summary>
    /// Gets or sets the product associated with this order item.
    /// </summary>
    public ProductEntity? Product { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the product ordered.
    /// </summary>
    [Column(OrderItemColumnNameConstants.Quantity)]
    [Required]
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the price of the product at the time of ordering.
    /// </summary>
    [Column(OrderItemColumnNameConstants.Price)]
    [Required]
    public decimal Price { get; set; }
}