using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class AddDateToOrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "07bf56fb-b4bb-4992-99ba-57235d0ba325");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3eae3269-d3b0-491b-b41e-e0aab403507c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a361e17d-37e9-4933-97b6-2fe651b28eb7");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "CartTable",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "db8dd43f-9199-43f9-9167-fd3cc4b03006", "148a4cc6-f40d-4879-8bf2-84b4e6b00ba1", "Buyer", "BUYER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd8d8d51-0ed4-4ad3-aac6-35cd5769cce0", "c06428df-b9dc-43cb-be31-a8323412ad8b", "Seller", "SELLER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aba859b2-7d27-4fed-8bb1-84b21fc6a54e", "bccd7c10-c44a-4d2b-bb03-0a78066a76b4", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "aba859b2-7d27-4fed-8bb1-84b21fc6a54e");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "db8dd43f-9199-43f9-9167-fd3cc4b03006");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fd8d8d51-0ed4-4ad3-aac6-35cd5769cce0");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "CartTable");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "07bf56fb-b4bb-4992-99ba-57235d0ba325", "85ad2ea2-cb61-41f5-ad28-a0a3a750f1b8", "Buyer", "BUYER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a361e17d-37e9-4933-97b6-2fe651b28eb7", "cd570b3e-33d9-493b-bfaa-36e7b6945b8c", "Seller", "SELLER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3eae3269-d3b0-491b-b41e-e0aab403507c", "dae687dd-45bb-4005-a8b8-6d5bca2df704", "Administrator", "ADMINISTRATOR" });
        }
    }
}
