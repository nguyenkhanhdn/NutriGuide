using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriGuide.Migrations
{
    /// <inheritdoc />
    public partial class hai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FoodName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GlycemicIndex = table.Column<float>(type: "real", nullable: false),
                    DateConsumed = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodRecords_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DateRecorded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BloodSugar = table.Column<float>(type: "real", nullable: false),
                    SystolicPressure = table.Column<int>(type: "int", nullable: false),
                    DiastolicPressure = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthRecords_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateOfBirth", "FullName", "Gender" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyễn Văn A", "Male" },
                    { 2, new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trần Thị B", "Female" },
                    { 3, new DateTime(2000, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lê Văn C", "Male" },
                    { 4, new DateTime(1995, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phạm Thị D", "Female" },
                    { 5, new DateTime(1992, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hoàng Văn E", "Male" },
                    { 6, new DateTime(1988, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đặng Thị F", "Female" },
                    { 7, new DateTime(2002, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bùi Văn G", "Male" },
                    { 8, new DateTime(1997, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ngô Thị H", "Female" },
                    { 9, new DateTime(1991, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dương Văn I", "Male" },
                    { 10, new DateTime(1999, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tô Thị J", "Female" },
                    { 11, new DateTime(1986, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lương Văn K", "Male" },
                    { 12, new DateTime(1994, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mai Thị L", "Female" },
                    { 13, new DateTime(2001, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vũ Văn M", "Male" },
                    { 14, new DateTime(1987, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lý Thị N", "Female" },
                    { 15, new DateTime(1993, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trịnh Văn O", "Male" }
                });

            migrationBuilder.InsertData(
                table: "FoodRecords",
                columns: new[] { "Id", "DateConsumed", "FoodName", "GlycemicIndex", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 17, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9182), "Bánh mì", 51f, 2 },
                    { 2, new DateTime(2025, 3, 16, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9192), "Táo", 52f, 3 },
                    { 3, new DateTime(2025, 3, 15, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9199), "Chuối", 53f, 4 },
                    { 4, new DateTime(2025, 3, 14, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9207), "Rau xanh", 54f, 5 },
                    { 5, new DateTime(2025, 3, 13, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9214), "Thịt bò", 55f, 6 },
                    { 6, new DateTime(2025, 3, 12, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9223), "Cá hồi", 56f, 7 },
                    { 7, new DateTime(2025, 3, 11, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9230), "Sữa chua", 57f, 8 },
                    { 8, new DateTime(2025, 3, 10, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9237), "Trứng", 58f, 9 },
                    { 9, new DateTime(2025, 3, 9, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9243), "Dưa hấu", 59f, 10 },
                    { 10, new DateTime(2025, 3, 8, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9251), "Cơm trắng", 60f, 1 },
                    { 11, new DateTime(2025, 3, 7, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9259), "Bánh mì", 61f, 2 },
                    { 12, new DateTime(2025, 3, 6, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9266), "Táo", 62f, 3 },
                    { 13, new DateTime(2025, 3, 5, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9274), "Chuối", 63f, 4 },
                    { 14, new DateTime(2025, 3, 4, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9281), "Rau xanh", 64f, 5 },
                    { 15, new DateTime(2025, 3, 3, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9288), "Thịt bò", 65f, 6 }
                });

            migrationBuilder.InsertData(
                table: "HealthRecords",
                columns: new[] { "Id", "BloodSugar", "DateRecorded", "DiastolicPressure", "SystolicPressure", "UserId" },
                values: new object[,]
                {
                    { 1, 91f, new DateTime(2025, 3, 17, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9012), 81, 121, 1 },
                    { 2, 92f, new DateTime(2025, 3, 16, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9029), 82, 122, 2 },
                    { 3, 93f, new DateTime(2025, 3, 15, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9039), 83, 123, 3 },
                    { 4, 94f, new DateTime(2025, 3, 14, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9047), 84, 124, 4 },
                    { 5, 95f, new DateTime(2025, 3, 13, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9056), 80, 125, 5 },
                    { 6, 96f, new DateTime(2025, 3, 12, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9066), 81, 126, 6 },
                    { 7, 97f, new DateTime(2025, 3, 11, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9074), 82, 127, 7 },
                    { 8, 98f, new DateTime(2025, 3, 10, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9082), 83, 128, 8 },
                    { 9, 99f, new DateTime(2025, 3, 9, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9090), 84, 129, 9 },
                    { 10, 100f, new DateTime(2025, 3, 8, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9099), 80, 120, 10 },
                    { 11, 101f, new DateTime(2025, 3, 7, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9133), 81, 121, 11 },
                    { 12, 102f, new DateTime(2025, 3, 6, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9142), 82, 122, 12 },
                    { 13, 103f, new DateTime(2025, 3, 5, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9151), 83, 123, 13 },
                    { 14, 104f, new DateTime(2025, 3, 4, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9159), 84, 124, 14 },
                    { 15, 105f, new DateTime(2025, 3, 3, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9167), 80, 125, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodRecords_UserId",
                table: "FoodRecords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthRecords_UserId",
                table: "HealthRecords",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodRecords");

            migrationBuilder.DropTable(
                name: "HealthRecords");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
