using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Layer.Migrations
{
    public partial class Mig_Add_ImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURl",
                table: "AspNetUsers");
        }
    }
}
