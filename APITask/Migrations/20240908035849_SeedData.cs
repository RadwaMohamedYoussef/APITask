using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APITask.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 19,
                column: "TransitionalStationId",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 22,
                column: "TransitionalStationId",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 43,
                column: "TransitionalStationId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 45,
                column: "TransitionalStationId",
                value: 19);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 19,
                column: "TransitionalStationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 22,
                column: "TransitionalStationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 43,
                column: "TransitionalStationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 45,
                column: "TransitionalStationId",
                value: null);
        }
    }
}
