using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class EditBillingInfoController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "CartTable",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "BillingInfoTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "CartTable");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "BillingInfoTable");
        }
    }
}
