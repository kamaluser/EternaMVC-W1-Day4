using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Eterna.Migrations
{
    public partial class DescAndButtonContentAddedToSliderİtem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ButtonContent",
                table: "SliderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "SliderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ButtonContent",
                table: "SliderItems");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "SliderItems");
        }
    }
}
