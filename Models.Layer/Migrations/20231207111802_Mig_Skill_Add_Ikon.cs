using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Layer.Migrations
{
    public partial class Mig_Skill_Add_Ikon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IkonUrl",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IkonUrl",
                table: "Skills");
        }
    }
}
