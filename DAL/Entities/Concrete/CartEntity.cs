using DAL.Constants;
using DAL.Constants.ColumnNameConstants;
using DAL.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities.Concrete;

/// <summary>
/// Represents a shopping cart entity in the e-commerce system.
/// </summary>
[Table(TableNameConstants.Cart)]
public class CartEntity : IDbEntity
{
    /// <summary>
    /// Unique identifier for the cart.
    /// </summary>
    [Key]
    [Column(CartColumnNameConstants.Id)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public int Id { get; set; }

}
