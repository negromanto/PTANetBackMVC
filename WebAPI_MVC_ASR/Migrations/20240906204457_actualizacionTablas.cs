using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI_MVC_ASR.Migrations
{
    /// <inheritdoc />
    public partial class actualizacionTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimestampUTC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImbalanceFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HourlyImbalanceFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PeakLoadFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VolumeFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    WeeklyFee = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feeds", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Feeds",
                columns: new[] { "Id", "Country", "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee", "WeeklyFee" },
                values: new object[,]
                {
                    { 1, "NO", null, null, null, "2017-05-01T00:00:00", "2017-04-30T22:00:00Z", null, 30 },
                    { 2, "FI", null, null, null, "2017-05-01T00:00:00", "2017-04-30T22:00:00Z", null, 30 },
                    { 3, "SE", null, null, 0.43m, "2017-05-01T00:00:00", "2017-04-30T22:00:00Z", null, 30 },
                    { 4, "DK", null, null, null, "2017-05-01T00:00:00", "2017-04-30T22:00:00Z", null, 0 },
                    { 5, "SE", null, null, 0.43m, "2018-11-15T23:00:00", "2018-11-15T22:00:00Z", null, 30 },
                    { 6, "SE", null, null, 0.35m, "2018-11-16T00:00:00", "2018-11-15T23:00:00Z", null, 30 },
                    { 7, "SE", null, null, 0.35m, "2019-11-15T23:00:00", "2019-11-15T22:00:00Z", null, 30 },
                    { 8, "SE", null, null, 0.31m, "2019-11-16T00:00:00", "2019-11-15T23:00:00Z", null, 30 },
                    { 9, "SE", null, null, 0.31m, "2020-11-15T23:00:00", "2020-11-15T22:00:00Z", null, 30 },
                    { 10, "SE", null, null, 0.27m, "2020-11-16T00:00:00", "2020-11-15T23:00:00Z", null, 30 },
                    { 11, "DK", null, null, null, "2021-01-31T23:00:00", "2021-01-31T22:00:00Z", null, 0 },
                    { 12, "DK", null, null, null, "2021-02-01T00:00:00", "2021-01-31T23:00:00Z", null, 30 },
                    { 13, "SE", null, null, 0.27m, "2021-10-31T23:00:00", "2021-10-31T22:00:00Z", null, 30 },
                    { 14, "NO", null, null, null, "2021-10-31T23:00:00", "2021-10-31T22:00:00Z", null, 30 },
                    { 15, "FI", null, null, null, "2021-10-31T23:00:00", "2021-10-31T22:00:00Z", null, 30 },
                    { 16, "DK", null, null, null, "2021-10-31T23:00:00", "2021-10-31T22:00:00Z", null, 30 },
                    { 17, "FI", null, 1.15m, null, "2021-11-01T00:00:00", "2021-10-31T23:00:00Z", 0.36m, 30 },
                    { 18, "SE", null, 1.15m, 0.27m, "2021-11-01T00:00:00", "2021-10-31T23:00:00Z", 0.85m, 30 },
                    { 19, "NO", null, 1.15m, null, "2021-11-01T00:00:00", "2021-10-31T23:00:00Z", 0.08m, 30 },
                    { 20, "DK", null, 0.133m, null, "2021-11-01T00:00:00", "2021-10-31T23:00:00Z", null, 30 },
                    { 21, "SE", null, 1.15m, 0.27m, "2021-11-15T23:00:00", "2021-11-15T22:00:00Z", 0.85m, 30 },
                    { 22, "SE", null, 1.15m, 0.32m, "2021-11-16T00:00:00", "2021-11-15T23:00:00Z", 0.85m, 30 },
                    { 23, "FI", null, 1.15m, null, "2022-01-31T22:00:00", "2022-01-31T21:00:00Z", 0.36m, 30 },
                    { 24, "FI", null, 1.15m, null, "2022-01-31T23:00:00", "2022-01-31T22:00:00Z", 0.41m, 30 },
                    { 25, "FI", null, 1.15m, null, "2022-04-30T22:00:00", "2022-04-30T20:00:00Z", 0.41m, 30 },
                    { 26, "FI", null, 1.15m, null, "2022-04-30T23:00:00", "2022-04-30T21:00:00Z", 0.64m, 30 },
                    { 27, "NO", null, 1.15m, null, "2022-05-31T23:00:00", "2022-05-31T21:00:00Z", 0.08m, 30 },
                    { 28, "NO", null, 1.15m, null, "2022-06-01T00:00:00", "2022-05-31T22:00:00Z", 0.13m, 30 },
                    { 29, "FI", null, 1.15m, null, "2022-08-31T22:00:00", "2022-08-31T20:00:00Z", 0.64m, 30 },
                    { 30, "FI", null, 1.15m, null, "2022-08-31T23:00:00", "2022-08-31T21:00:00Z", 1.2m, 30 },
                    { 31, "SE", null, 1.15m, 0.32m, "2022-11-15T23:00:00", "2022-11-15T22:00:00Z", 0.85m, 30 },
                    { 32, "SE", null, 1.15m, 0.33m, "2022-11-16T00:00:00", "2022-11-15T23:00:00Z", 0.85m, 30 },
                    { 33, "FI", null, 1.15m, null, "2022-12-31T23:00:00", "2022-12-31T22:00:00Z", 1.7m, 30 },
                    { 34, "SE", null, 1.15m, 0.33m, "2022-12-31T23:00:00", "2022-12-31T22:00:00Z", 0.85m, 30 },
                    { 35, "SE", null, 1.15m, 0.33m, "2023-01-01T00:00:00", "2022-12-31T23:00:00Z", 1.2m, 30 },
                    { 36, "FI", null, 1.15m, null, "2023-04-30T22:00:00", "2023-04-30T20:00:00Z", 1.7m, 30 },
                    { 37, "NO", null, 1.15m, null, "2023-05-21T23:00:00", "2023-05-21T21:00:00Z", 0.13m, 30 },
                    { 38, "FI", null, 1.15m, null, "2023-05-21T23:00:00", "2023-05-21T21:00:00Z", 1.2m, 30 },
                    { 39, "DK", null, 0.133m, null, "2023-05-21T23:00:00", "2023-05-21T21:00:00Z", null, 30 },
                    { 40, "SE", null, 1.15m, 0.33m, "2023-05-21T23:00:00", "2023-05-21T21:00:00Z", 1.2m, 30 },
                    { 41, "NO", 1.15m, null, null, "2023-06-01T00:00:00", "2023-05-31T22:00:00Z", 0.13m, 30 },
                    { 42, "SE", 1.15m, null, 0.33m, "2023-06-01T00:00:00", "2023-05-31T22:00:00Z", 1.2m, 30 },
                    { 43, "DK", 0.133m, null, null, "2023-06-01T00:00:00", "2023-05-31T22:00:00Z", null, 30 },
                    { 44, "FI", 1.15m, null, null, "2023-06-01T00:00:00", "2023-05-31T22:00:00Z", 1.2m, 30 },
                    { 45, "FI", 1.15m, null, null, "2023-10-31T22:00:00", "2023-10-31T21:00:00Z", 1.2m, 30 },
                    { 46, "FI", 1.15m, null, null, "2023-10-31T23:00:00", "2023-10-31T22:00:00Z", 1.5m, 30 },
                    { 47, "SE", 1.15m, null, 0.33m, "2023-11-15T23:00:00", "2023-11-15T22:00:00Z", 1.2m, 30 },
                    { 48, "SE", 1.15m, null, 0.29m, "2023-11-16T00:00:00", "2023-11-15T23:00:00Z", 1.2m, 30 },
                    { 49, "NO", 1.15m, null, null, "2023-12-31T23:00:00", "2023-12-31T22:00:00Z", 0.13m, 30 },
                    { 50, "SE", 1.15m, null, 0.29m, "2023-12-31T23:00:00", "2023-12-31T22:00:00Z", 1.2m, 30 },
                    { 51, "SE", 1.15m, null, 0.29m, "2024-01-01T00:00:00", "2023-12-31T23:00:00Z", 1.6m, 30 },
                    { 52, "NO", 1.15m, null, null, "2024-01-01T00:00:00", "2023-12-31T23:00:00Z", 0.21m, 30 },
                    { 53, "FI", 1.15m, null, null, "2024-02-29T22:00:00", "2024-02-29T21:00:00Z", 1.5m, 30 },
                    { 54, "FI", 1.15m, null, null, "2024-02-29T23:00:00", "2024-02-29T22:00:00Z", 1.33m, 30 },
                    { 55, "SE", 1.15m, null, 0.29m, "2024-09-01T23:00:00", "2024-09-01T21:00:00Z", 1.6m, 30 },
                    { 56, "NO", 1.15m, null, null, "2024-09-01T23:00:00", "2024-09-01T21:00:00Z", 0.21m, 30 },
                    { 57, "DK", 0.133m, null, null, "2024-09-01T23:00:00", "2024-09-01T21:00:00Z", null, 30 },
                    { 58, "FI", 1.15m, null, null, "2024-09-01T23:00:00", "2024-09-01T21:00:00Z", 1.33m, 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feeds");
        }
    }
}
