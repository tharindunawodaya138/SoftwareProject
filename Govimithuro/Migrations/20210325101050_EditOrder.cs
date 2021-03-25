using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class EditOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "OrderTable",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecef65bb-8e0c-43d7-911f-a2c08ee4b355", "cdcaff7a-049b-48c0-a666-5af7f83377c8", "Buyer", "BUYER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "63acb5e9-e38c-4703-88bd-d488c7ea0bdb", "54da2c69-a81d-498a-9520-7410f4e64fba", "Seller", "SELLER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19b4e086-f15c-401d-b53a-7c8b7c2d53ae", "02b6aa30-fbe2-4202-9518-67cfa27e3bc4", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "19b4e086-f15c-401d-b53a-7c8b7c2d53ae");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "63acb5e9-e38c-4703-88bd-d488c7ea0bdb");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ecef65bb-8e0c-43d7-911f-a2c08ee4b355");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "OrderTable");

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
    }
}
