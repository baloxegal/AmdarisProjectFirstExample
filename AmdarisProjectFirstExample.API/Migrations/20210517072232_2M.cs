using Microsoft.EntityFrameworkCore.Migrations;

namespace AmdarisProjectFirstExample.API.Migrations
{
    public partial class _2M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoginName",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LoginName",
                table: "AspNetUsers",
                type: "nvarchar(150)",
                nullable: true);
        }
    }
}
