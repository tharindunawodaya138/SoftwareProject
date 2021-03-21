using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class SetOrderDetailsModelToGetFeedBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "527b5204-327d-4a34-bcb5-e21fbeb4d388");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7ccd5b06-9511-4bb0-9bda-04d8b10428da");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b7d28700-7dee-434a-b507-2482e0558ce7");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "OrderDetailsTable");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderDetailsTable");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderDetailsTable");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "OrderDetailsTable");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "OrderDetailsTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Feedback",
                table: "OrderDetailsTable",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d583510-872e-48de-affb-b411e2f671dc", "d7787383-18df-4353-8272-30fe0c7440f6", "Buyer", "BUYER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f541f7ab-3da8-4168-8d53-373a798979cd", "411a3845-3882-48b6-8cc4-18137692bc1a", "Seller", "SELLER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20127f82-1431-4fcc-9c4e-f64449fb75fb", "897195ac-1cde-4298-9d64-ccb8faf2a6c5", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "20127f82-1431-4fcc-9c4e-f64449fb75fb");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3d583510-872e-48de-affb-b411e2f671dc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f541f7ab-3da8-4168-8d53-373a798979cd");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "OrderDetailsTable");

            migrationBuilder.DropColumn(
                name: "Feedback",
                table: "OrderDetailsTable");

            migrationBuilder.AddColumn<int>(
                name: "OrderNumber",
                table: "OrderDetailsTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "OrderDetailsTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Quantity",
                table: "OrderDetailsTable",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UnitPrice",
                table: "OrderDetailsTable",
                type: "real",
                nullable: false,
                defaultValue: 0f);

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
    }
}
