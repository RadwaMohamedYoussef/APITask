using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APITask.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isTransitional = table.Column<bool>(type: "bit", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    LineId = table.Column<int>(type: "int", nullable: false),
                    TransitionalStationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stations_Lines_LineId",
                        column: x => x.LineId,
                        principalTable: "Lines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stations_Stations_TransitionalStationId",
                        column: x => x.TransitionalStationId,
                        principalTable: "Stations",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Lines",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Line 1" },
                    { 2, "Line 2" }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "LineId", "Name", "Position", "TransitionalStationId", "isTransitional" },
                values: new object[,]
                {
                    { 1, 1, "Helwan", 1, null, false },
                    { 2, 1, "Ain Helwan", 2, null, false },
                    { 3, 1, "Helwan University", 3, null, false },
                    { 4, 1, "Wadi Hof", 4, null, false },
                    { 5, 1, "Hadayek Helwan", 5, null, false },
                    { 6, 1, "El-Maasara", 6, null, false },
                    { 7, 1, "Tora El-Balad", 7, null, false },
                    { 8, 1, "Kozzika", 8, null, false },
                    { 9, 1, "Tora El-Asmant", 9, null, false },
                    { 10, 1, "Sakanat El-Maadi", 10, null, false },
                    { 11, 1, "Maadi", 11, null, false },
                    { 12, 1, "Hadayek El-Maadi", 12, null, false },
                    { 13, 1, "Dar El-Salam", 13, null, false },
                    { 14, 1, "El-Zahraa", 14, null, false },
                    { 15, 1, "Mar Girgis", 15, null, false },
                    { 16, 1, "El-Malek El-Saleh", 16, null, false },
                    { 17, 1, "Al-Sayeda Zeinab", 17, null, false },
                    { 18, 1, "Saad Zaghloul", 18, null, false },
                    { 19, 1, "Sadat", 19, null, true },
                    { 20, 1, "Nasser", 20, null, false },
                    { 21, 1, "Orabi", 21, null, false },
                    { 22, 1, "Al-Shohadaa", 22, null, true },
                    { 23, 1, "Ghamra", 23, null, false },
                    { 24, 1, "El-Demerdash", 24, null, false },
                    { 25, 1, "Manshiet El-Sadr", 25, null, false },
                    { 26, 1, "Kobri El-Qobba", 26, null, false },
                    { 27, 1, "Hammamat El-Qobba", 27, null, false },
                    { 28, 1, "Saray El-Qobba", 28, null, false },
                    { 29, 1, "Hadayeq El-Zaitoun", 29, null, false },
                    { 30, 1, "Helmeyet El-Zaitoun", 30, null, false },
                    { 31, 1, "El-Matareyya", 31, null, false },
                    { 32, 1, "Ain Shams", 32, null, false },
                    { 33, 1, "Ezbet El-Nakhl", 33, null, false },
                    { 34, 1, "El-Marg", 34, null, false },
                    { 35, 1, "El-Marg El-Gedida", 35, null, false },
                    { 36, 2, "Shubra El-Kheima", 1, null, false },
                    { 37, 2, "Kolleyet El-Zeraa", 2, null, false },
                    { 38, 2, "El-Mazalat", 3, null, false },
                    { 39, 2, "El-Khalafawi", 4, null, false },
                    { 40, 2, "St. Teresa", 5, null, false },
                    { 41, 2, "Rod El-Farag", 6, null, false },
                    { 42, 2, "Masarra", 7, null, false },
                    { 43, 2, "Al-Shohadaa", 8, null, true },
                    { 44, 2, "Attaba", 9, null, false },
                    { 45, 2, "Sadat", 10, null, true },
                    { 46, 2, "Opera", 11, null, false },
                    { 47, 2, "Dokki", 12, null, false },
                    { 48, 2, "Cairo University", 13, null, false },
                    { 49, 2, "Faisal", 14, null, false },
                    { 50, 2, "Giza", 15, null, false },
                    { 51, 2, "Omm El-Masryeen", 16, null, false },
                    { 52, 2, "Sakiat Mekki", 17, null, false },
                    { 53, 2, "El-Mounib", 18, null, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stations_LineId",
                table: "Stations",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_Stations_TransitionalStationId",
                table: "Stations",
                column: "TransitionalStationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Lines");
        }
    }
}
