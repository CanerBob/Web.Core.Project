using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Layer.Migrations
{
    public partial class Mig_Add_WriterMessage_revize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "WriterMessages",
                newName: "MessageContent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageContent",
                table: "WriterMessages",
                newName: "Content");
        }
    }
}
