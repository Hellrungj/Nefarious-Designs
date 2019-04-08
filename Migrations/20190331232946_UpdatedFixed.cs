using Microsoft.EntityFrameworkCore.Migrations;

namespace NefariousDesigns.Migrations
{
    public partial class UpdatedFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Shirts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Shirts",
                nullable: false,
                defaultValue: false);
        }
    }
}
