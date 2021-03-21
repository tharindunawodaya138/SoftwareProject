using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class EditProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1f4dc520-47f0-467f-9d03-50ef6c6b9de7");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "212d013b-eae3-42fa-a5cc-dca3e44d36d8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "de3896ae-3e8d-49e7-88ef-febbcf31133b");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ProductTable",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Email",
                table: "ProductTable");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "212d013b-eae3-42fa-a5cc-dca3e44d36d8", "35378d97-b4c0-4665-91c7-26b6da5865b2", "Buyer", "BUYER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de3896ae-3e8d-49e7-88ef-febbcf31133b", "8b62760e-8c02-4496-8d2e-127c0d9d79b6", "Seller", "SELLER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f4dc520-47f0-467f-9d03-50ef6c6b9de7", "c82faaa8-e087-455e-a930-286660272487", "Administrator", "ADMINISTRATOR" });
        }
    }
}
