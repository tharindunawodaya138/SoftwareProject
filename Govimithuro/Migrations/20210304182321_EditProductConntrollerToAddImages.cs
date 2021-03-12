using Microsoft.EntityFrameworkCore.Migrations;

namespace Govimithuro.Migrations
{
    public partial class EditProductConntrollerToAddImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "ProductTable");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "ProductTable",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "ProductTable");

            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "ProductTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
