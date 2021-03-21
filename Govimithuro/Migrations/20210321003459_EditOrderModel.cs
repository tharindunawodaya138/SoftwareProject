using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class EditOrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "OrderTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "OrderTable",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb92e9c3-91dc-493e-ac0a-5bef3bbc943c", "df350fe7-5142-46f9-ad62-5abc6c7174a3", "Buyer", "BUYER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a9b2fed-831c-4f9d-9196-6f53cca7339d", "c66bbee6-157e-43af-8ac4-435c3d522ba7", "Seller", "SELLER" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fbd23870-9da9-4708-a6bd-06578db6df2b", "20034185-a0d4-4e77-8c61-ea29b4f46607", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5a9b2fed-831c-4f9d-9196-6f53cca7339d");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fb92e9c3-91dc-493e-ac0a-5bef3bbc943c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "fbd23870-9da9-4708-a6bd-06578db6df2b");

            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "OrderTable");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "OrderTable");

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
    }
}
