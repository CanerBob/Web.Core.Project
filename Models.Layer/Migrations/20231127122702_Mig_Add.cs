using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Layer.Migrations
{
    public partial class Mig_Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Test2s",
                table: "Test2s");

            migrationBuilder.RenameTable(
                name: "Test2s",
                newName: "Test1s");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Test1s",
                table: "Test1s",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Test1s",
                table: "Test1s");

            migrationBuilder.RenameTable(
                name: "Test1s",
                newName: "Test2s");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Test2s",
                table: "Test2s",
                column: "Id");
        }
    }
}
