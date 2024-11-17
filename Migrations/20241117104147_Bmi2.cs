using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriGuide.Migrations
{
    /// <inheritdoc />
    public partial class Bmi2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tuổi của trẻ",
                table: "Bmis",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "BMI TB của bé trai",
                table: "Bmis",
                newName: "MaleBmi");

            migrationBuilder.RenameColumn(
                name: "BMI TB của bé gái",
                table: "Bmis",
                newName: "FenaleBmi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaleBmi",
                table: "Bmis",
                newName: "BMI TB của bé trai");

            migrationBuilder.RenameColumn(
                name: "FenaleBmi",
                table: "Bmis",
                newName: "BMI TB của bé gái");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Bmis",
                newName: "Tuổi của trẻ");
        }
    }
}
