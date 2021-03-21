using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class EditOrderandProduct1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "90276467-090f-4668-ab28-61f4b0b451e8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "cfa8ecb6-f4d8-4d88-a508-98bf8ddda763");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d2f94e42-2002-435b-b0c1-74b7feb2155f");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90276467-090f-4668-ab28-61f4b0b451e8", "a6b7c8d6-1f80-464b-bb67-fef02018fe8b", "Buyer", "BUYER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2f94e42-2002-435b-b0c1-74b7feb2155f", "6061c173-8411-429d-9f1d-ea8f5621e350", "Seller", "SELLER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfa8ecb6-f4d8-4d88-a508-98bf8ddda763", "3d73ecc9-61b1-4609-9076-7850f46c242b", "Administrator", "ADMINISTRATOR" });
        }
    }
}
