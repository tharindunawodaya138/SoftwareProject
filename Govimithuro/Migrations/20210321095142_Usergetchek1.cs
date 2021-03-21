using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class Usergetchek1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminTable",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminFName = table.Column<string>(nullable: true),
                    AdminLName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTable", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "BillingInfoTable",
                columns: table => new
                {
                    BillingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardName = table.Column<string>(nullable: true),
                    CardNo = table.Column<string>(nullable: true),
                    ExpDate = table.Column<string>(nullable: true),
                    Cvv = table.Column<int>(nullable: false),
                    BillDate = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingInfoTable", x => x.BillingId);
                });

            migrationBuilder.CreateTable(
                name: "CartTable",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(nullable: false),
                    NumOfProducts = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartTable", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTable",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTable", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTable",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTable", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "FarmerTable",
                columns: table => new
                {
                    FarmerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmerFName = table.Column<string>(nullable: true),
                    FarmerLName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ASCRNo = table.Column<string>(nullable: true),
                    AgriBranch = table.Column<string>(nullable: true),
                    NIC = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmerTable", x => x.FarmerID);
                });

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "LoginTable",
                columns: table => new
                {
                    LoginId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginTable", x => x.LoginId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetailsTable",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<float>(nullable: false),
                    Quantity = table.Column<float>(nullable: false),
                    OrderNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetailsTable", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "OrderTable",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    Quantity = table.Column<float>(nullable: false),
                    UnitPrice = table.Column<float>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    CustomerEmail = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTable", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTable",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ReorderLevel = table.Column<int>(nullable: false),
                    Quantity = table.Column<float>(nullable: false),
                    Addresse = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<float>(nullable: false),
                    UnitWeight = table.Column<float>(nullable: false),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTable", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "UserTable",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    AscrNo = table.Column<string>(nullable: true),
                    AgriBranch = table.Column<string>(nullable: true),
                    Nic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTable", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "527b5204-327d-4a34-bcb5-e21fbeb4d388", "9325f796-7c80-496e-8c0e-99cc1d68a346", "Buyer", "BUYER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ccd5b06-9511-4bb0-9bda-04d8b10428da", "99a2524e-dc23-4698-bbca-64054efb6324", "Seller", "SELLER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7d28700-7dee-434a-b507-2482e0558ce7", "4066f8d6-9896-4e7c-8e80-cc808c4bddcf", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminTable");

            migrationBuilder.DropTable(
                name: "BillingInfoTable");

            migrationBuilder.DropTable(
                name: "CartTable");

            migrationBuilder.DropTable(
                name: "CategoryTable");

            migrationBuilder.DropTable(
                name: "CustomerTable");

            migrationBuilder.DropTable(
                name: "FarmerTable");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "IdentityUserRole<string>");

            migrationBuilder.DropTable(
                name: "LoginTable");

            migrationBuilder.DropTable(
                name: "OrderDetailsTable");

            migrationBuilder.DropTable(
                name: "OrderTable");

            migrationBuilder.DropTable(
                name: "ProductTable");

            migrationBuilder.DropTable(
                name: "UserTable");
        }
    }
}
