using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieWebApp.Migrations.ApplicationDB
{
    public partial class IdentityUserToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserCheckedOut",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCheckedOut",
                table: "Movies");
        }
    }
}
