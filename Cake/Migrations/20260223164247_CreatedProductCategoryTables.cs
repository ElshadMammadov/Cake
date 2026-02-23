using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cake.Migrations
{
    public partial class CreatedProductCategoryTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "ProductPreviews",
                newName: "Image");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "ProductPreviews",
                newName: "ImageUrl");
        }
    }
}
