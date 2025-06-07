using DAL.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DAL.Db;

/// <summary>
/// Represents the application database context for the e-commerce system.
/// </summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    /// <summary>
    /// Gets or sets the DbSet for shopping carts in the e-commerce system.
    /// </summary>
    public DbSet<CartEntity> Carts { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for categories in the e-commerce system.
    /// </summary>
    public DbSet<CategoryEntity> Categories { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for products in the e-commerce system.
    /// </summary>
    public DbSet<ProductEntity> Products { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for users in the e-commerce system.
    /// </summary>
    public DbSet<UserEntity> Users { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for orders in the e-commerce system.
    /// </summary>
    public DbSet<OrderEntity> Orders { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for order items in the e-commerce system.
    /// </summary>
    public DbSet<OrderItemEntity> OrderItems { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for cart items in the e-commerce system.
    /// </summary>
    public DbSet<CartItemEntity> CartItems { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for user roles in the e-commerce system.
    /// </summary>
    public DbSet<UserRoleEntity> UserRoles { get; set; }
}
