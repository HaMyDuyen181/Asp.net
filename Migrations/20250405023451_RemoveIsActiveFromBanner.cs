using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaMyDuyen_2122110528.Migrations
{
    public partial class RemoveIsActiveFromBanner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Banners");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Banners",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
