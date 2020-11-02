using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieWebAppLabs_21222324.Migrations.ApplicationDB
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Runtime = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "Name", "Runtime" },
                values: new object[,]
                {
                    { 1, "Anitmation", "The Little Mermaid", 1.54 },
                    { 2, "Action", "Pirates of The Caribbean", 1.54 },
                    { 3, "Romantic Comedy", "When Harry Met Sally", 1.54 },
                    { 4, "Drama", "The Imitation Game", 1.54 },
                    { 5, "Biopic", "Hidden Figures", 1.54 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
