using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class EditOrder1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7c8587a4-a4ef-440e-8d83-58e59c8cd5ed");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f0d3cb48-f5ce-4430-8e7c-fb0fe5bf41a8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f7543301-392c-48d4-b5fe-1148d0ab147e");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "OrderTable");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "OrderTable");

            migrationBuilder.DropColumn(
                name: "OrderdDate",
                table: "OrderTable");

            migrationBuilder.DropColumn(
                name: "RequiredDate",
                table: "OrderTable");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "OrderTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "OrderTable",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "UnitPrice",
                table: "OrderTable",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "875f9a12-bba0-426a-a9c5-0d73dc2f2b20", "2bb17dc7-a0ae-4234-8d92-1515558704c9", "Buyer", "BUYER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6e1c090-b0f7-48a0-b9ca-cb6de3fd0e59", "04b004ab-8b37-4a5f-983e-f8c777d3d5a5", "Seller", "SELLER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c63edee-3d43-479f-97df-7498269b119b", "66437533-657d-4ef8-a3b0-b0e34a31e8ae", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "875f9a12-bba0-426a-a9c5-0d73dc2f2b20");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9c63edee-3d43-479f-97df-7498269b119b");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d6e1c090-b0f7-48a0-b9ca-cb6de3fd0e59");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "OrderTable");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "OrderTable");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "OrderTable");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "OrderTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderNumber",
                table: "OrderTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OrderdDate",
                table: "OrderTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequiredDate",
                table: "OrderTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c8587a4-a4ef-440e-8d83-58e59c8cd5ed", "ec8dda99-d180-49b2-9e4f-f0bb9c5d0bc3", "Buyer", "BUYER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7543301-392c-48d4-b5fe-1148d0ab147e", "d65195a8-c4d1-47f9-9906-fc3f7bb32aa9", "Seller", "SELLER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0d3cb48-f5ce-4430-8e7c-fb0fe5bf41a8", "e4c86ed1-8bfe-4451-902f-0999a352e622", "Administrator", "ADMINISTRATOR" });
        }
    }
}
