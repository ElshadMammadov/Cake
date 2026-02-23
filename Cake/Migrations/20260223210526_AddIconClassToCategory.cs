using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cake.Migrations
{
    public partial class AddIconClassToCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconClass",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconClass",
                table: "Categories");
        }
    }
}
