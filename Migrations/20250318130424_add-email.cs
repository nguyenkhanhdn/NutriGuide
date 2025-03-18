using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriGuide.Migrations
{
    /// <inheritdoc />
    public partial class addemail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 17, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 16, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 15, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 14, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 13, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 12, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 11, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 10, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 9, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 8, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 7, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 6, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 5, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 4, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 3, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 17, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 16, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 15, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 14, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 13, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 12, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 11, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 10, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 9, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 8, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 7, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 6, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 5, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 4, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 3, 13, 4, 23, 819, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "nguyenvana@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "tranthib@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "levanc@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "Email",
                value: "phamthid@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "Email",
                value: "hoangvane@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "Email",
                value: "dangthif@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "Email",
                value: "buivang@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "Email",
                value: "ngothih@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "Email",
                value: "duongvani@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Email",
                value: "tothij@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "Email",
                value: "luongvank@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "Email",
                value: "maithil@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "Email",
                value: "vuvan@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "Email",
                value: "lythin@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "Email",
                value: "trinhvano@example.com");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 17, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 16, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 15, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 14, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 13, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 12, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 11, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 10, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 9, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 8, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 7, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 6, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 5, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 4, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateConsumed",
                value: new DateTime(2025, 3, 3, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 17, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 16, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 15, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 14, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 13, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 12, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 11, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 10, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 9, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 8, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 7, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 6, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 5, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 4, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "HealthRecords",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateRecorded",
                value: new DateTime(2025, 3, 3, 4, 31, 32, 681, DateTimeKind.Utc).AddTicks(9167));
        }
    }
}
