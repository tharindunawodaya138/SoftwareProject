using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class EditBillingInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "ExpDate",
                table: "BillingInfoTable");

            migrationBuilder.AlterColumn<string>(
                name: "Cvv",
                table: "BillingInfoTable",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ExpMonth",
                table: "BillingInfoTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpYear",
                table: "BillingInfoTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPrice",
                table: "BillingInfoTable",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ExpMonth",
                table: "BillingInfoTable");

            migrationBuilder.DropColumn(
                name: "ExpYear",
                table: "BillingInfoTable");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "BillingInfoTable");

            migrationBuilder.AlterColumn<int>(
                name: "Cvv",
                table: "BillingInfoTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExpDate",
                table: "BillingInfoTable",
                type: "nvarchar(max)",
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
    }
}
