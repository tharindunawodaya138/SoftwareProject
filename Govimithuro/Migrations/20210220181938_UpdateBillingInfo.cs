using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class UpdateBillingInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CardNo",
                table: "BillingInfoTable",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CardName",
                table: "BillingInfoTable",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cvv",
                table: "BillingInfoTable",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardName",
                table: "BillingInfoTable");

            migrationBuilder.DropColumn(
                name: "Cvv",
                table: "BillingInfoTable");

            migrationBuilder.AlterColumn<int>(
                name: "CardNo",
                table: "BillingInfoTable",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
