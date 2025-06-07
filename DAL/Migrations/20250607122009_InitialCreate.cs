using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carts",
                columns: table => new
                {
                    cart_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carts", x => x.cart_id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category_name = table.Column<string>(type: "TEXT", nullable: false),
                    category_description = table.Column<string>(type: "TEXT", nullable: false),
                    category_createdAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    category_lastUpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "userRoles",
                columns: table => new
                {
                    userRole_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userRole_name = table.Column<string>(type: "TEXT", nullable: false),
                    userRole_description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRoles", x => x.userRole_id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    product_name = table.Column<string>(type: "TEXT", nullable: false),
                    product_description = table.Column<string>(type: "TEXT", nullable: true),
                    product_categoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    product_price = table.Column<decimal>(type: "TEXT", nullable: false),
                    product_stockQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    product_createdAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    product_updatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_id);
                    table.ForeignKey(
                        name: "FK_Products_categories_product_categoryId",
                        column: x => x.product_categoryId,
                        principalTable: "categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    user_firstName = table.Column<string>(type: "TEXT", nullable: false),
                    user_lastName = table.Column<string>(type: "TEXT", nullable: false),
                    user_dateOfBirth = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    user_username = table.Column<string>(type: "TEXT", nullable: false),
                    user_email = table.Column<string>(type: "TEXT", nullable: false),
                    user_passwordHash = table.Column<string>(type: "TEXT", nullable: false),
                    user_createdAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    user_lastUpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    user_cartId = table.Column<int>(type: "INTEGER", nullable: false),
                    user_roleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_users_carts_user_cartId",
                        column: x => x.user_cartId,
                        principalTable: "carts",
                        principalColumn: "cart_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_userRoles_user_roleId",
                        column: x => x.user_roleId,
                        principalTable: "userRoles",
                        principalColumn: "userRole_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cartItems",
                columns: table => new
                {
                    cart_item_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cart_item_cartId = table.Column<int>(type: "INTEGER", nullable: false),
                    cart_item_productId = table.Column<int>(type: "INTEGER", nullable: false),
                    cart_item_quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    cart_item_price = table.Column<decimal>(type: "TEXT", nullable: false),
                    cart_item_addedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    cart_item_updatedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cartItems", x => x.cart_item_id);
                    table.ForeignKey(
                        name: "FK_cartItems_Products_cart_item_productId",
                        column: x => x.cart_item_productId,
                        principalTable: "Products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cartItems_carts_cart_item_cartId",
                        column: x => x.cart_item_cartId,
                        principalTable: "carts",
                        principalColumn: "cart_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    order_userId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalAmountWithoutDiscount = table.Column<decimal>(type: "TEXT", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.order_id);
                    table.ForeignKey(
                        name: "FK_orders_users_order_userId",
                        column: x => x.order_userId,
                        principalTable: "users",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderItems",
                columns: table => new
                {
                    order_item_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    order_item_orderId = table.Column<int>(type: "INTEGER", nullable: false),
                    order_item_productId = table.Column<int>(type: "INTEGER", nullable: false),
                    order_item_quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    order_item_price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderItems", x => x.order_item_id);
                    table.ForeignKey(
                        name: "FK_orderItems_Products_order_item_productId",
                        column: x => x.order_item_productId,
                        principalTable: "Products",
                        principalColumn: "product_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orderItems_orders_order_item_orderId",
                        column: x => x.order_item_orderId,
                        principalTable: "orders",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cartItems_cart_item_cartId",
                table: "cartItems",
                column: "cart_item_cartId");

            migrationBuilder.CreateIndex(
                name: "IX_cartItems_cart_item_productId",
                table: "cartItems",
                column: "cart_item_productId");

            migrationBuilder.CreateIndex(
                name: "IX_orderItems_order_item_orderId",
                table: "orderItems",
                column: "order_item_orderId");

            migrationBuilder.CreateIndex(
                name: "IX_orderItems_order_item_productId",
                table: "orderItems",
                column: "order_item_productId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_order_userId",
                table: "orders",
                column: "order_userId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_product_categoryId",
                table: "Products",
                column: "product_categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_users_user_cartId",
                table: "users",
                column: "user_cartId");

            migrationBuilder.CreateIndex(
                name: "IX_users_user_roleId",
                table: "users",
                column: "user_roleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cartItems");

            migrationBuilder.DropTable(
                name: "orderItems");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "carts");

            migrationBuilder.DropTable(
                name: "userRoles");
        }
    }
}
