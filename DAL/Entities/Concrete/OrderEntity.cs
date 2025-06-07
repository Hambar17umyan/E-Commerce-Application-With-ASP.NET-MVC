using DAL.Constants;
using DAL.Constants.ColumnNameConstants;
using DAL.Entities.Abstract;
using Domain.Models.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Concrete;

/// <summary>
/// Represents an order entity in the e-commerce system.
/// </summary>
[Table(TableNameConstants.Order)]
public class OrderEntity : IDbEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the order entity.
    /// </summary>
    [Key]
    [Required]
    [Column(OrderColumnNameConstants.Id)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the User identifier associated with the order.
    /// </summary>
    [Required]
    [Column(OrderColumnNameConstants.UserId)]
    [ForeignKey(nameof(this.User))]
    public int UserId { get; set; }

    /// <summary>
    /// Gets or sets the list of items included in the order.
    /// </summary>
    public List<OrderItemEntity> Items { get; set; } = new List<OrderItemEntity>();

    /// <summary>
    /// Gets or sets the date and time when the order was placed.
    /// </summary>
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the total amount of the order before any discounts are applied.
    /// </summary>
    public decimal TotalAmountWithoutDiscount { get; set; }

    /// <summary>
    /// Gets or sets the discount amount applied to the order.
    /// </summary>
    public decimal DiscountAmount { get; set; }

    /// <summary>
    /// Gets or sets the status of the order.
    /// </summary>
    public OrderStatus Status { get; set; } = OrderStatus.None;

    public UserEntity User { get; set; } = new UserEntity();
}
