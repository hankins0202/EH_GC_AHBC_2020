using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieWebAppLabs_21222324.Migrations.ApplicationDB
{
    public partial class CheckoutFieldadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CheckedOut",
                table: "Movies",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckedOut",
                table: "Movies");
        }
    }
}
