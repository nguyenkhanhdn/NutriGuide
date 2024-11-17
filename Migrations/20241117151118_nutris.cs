using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriGuide.Migrations
{
    /// <inheritdoc />
    public partial class nutris : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nutris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nutrient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Symptom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Food2Eat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount2Eat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutris", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nutris");
        }
    }
}
