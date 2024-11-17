using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriGuide.Migrations
{
    /// <inheritdoc />
    public partial class nutris2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Nutris",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Nutris");
        }
    }
}
