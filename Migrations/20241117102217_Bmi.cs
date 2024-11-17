using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriGuide.Migrations
{
    /// <inheritdoc />
    public partial class Bmi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bmis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tuổicủatrẻ = table.Column<string>(name: "Tuổi của trẻ", type: "nvarchar(max)", nullable: false),
                    BMITBcủabétrai = table.Column<float>(name: "BMI TB của bé trai", type: "real", nullable: false),
                    BMITBcủabégái = table.Column<float>(name: "BMI TB của bé gái", type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bmis", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bmis");
        }
    }
}
