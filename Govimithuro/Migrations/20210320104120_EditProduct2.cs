using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class EditProduct2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "SupplierId",
                table: "ProductTable");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad5698bb-e1ab-43d3-be33-51d3820528a4", "8c0ac3ec-13a5-4c75-8081-024564902a48", "Buyer", "BUYER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b8995d38-62a7-4f76-8415-136002f0a0be", "d51ee333-476c-4e4d-9372-1ae4f9fe3c17", "Seller", "SELLER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0592dfcb-74d0-410c-9c25-251bad183f90", "db19ecae-6ffc-42ff-92f2-c1e5b1dc5db8", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0592dfcb-74d0-410c-9c25-251bad183f90");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ad5698bb-e1ab-43d3-be33-51d3820528a4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b8995d38-62a7-4f76-8415-136002f0a0be");

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "ProductTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
