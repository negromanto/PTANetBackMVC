using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI_MVC_ASR.Migrations
{
    /// <inheritdoc />
    public partial class AlimentartablaFeeds1 : Migration
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
                    Timestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TimestampUTC = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImbalanceFee = table.Column<float>(type: "real", nullable: true),
                    HourlyImbalanceFee = table.Column<float>(type: "real", nullable: true),
                    PeakLoadFee = table.Column<float>(type: "real", nullable: true),
                    VolumeFee = table.Column<float>(type: "real", nullable: true),
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
                    { 1, "NO", null, null, null, new DateTimeOffset(new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2017, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 2, "FI", null, null, null, new DateTimeOffset(new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2017, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 3, "SE", null, null, 0.43f, new DateTimeOffset(new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2017, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 4, "DK", null, null, null, new DateTimeOffset(new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2017, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 0 },
                    { 5, "SE", null, null, 0.43f, new DateTimeOffset(new DateTime(2018, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 11, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 6, "SE", null, null, 0.35f, new DateTimeOffset(new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 7, "SE", null, null, 0.35f, new DateTimeOffset(new DateTime(2019, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2019, 11, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 8, "SE", null, null, 0.31f, new DateTimeOffset(new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2019, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 9, "SE", null, null, 0.31f, new DateTimeOffset(new DateTime(2020, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 10, "SE", null, null, 0.27f, new DateTimeOffset(new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 11, "DK", null, null, null, new DateTimeOffset(new DateTime(2021, 1, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 0 },
                    { 12, "DK", null, null, null, new DateTimeOffset(new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 13, "SE", null, null, 0.27f, new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 14, "NO", null, null, null, new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 15, "FI", null, null, null, new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 16, "DK", null, null, null, new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 17, "FI", null, 1.15f, null, new DateTimeOffset(new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.36f, 30 },
                    { 18, "SE", null, 1.15f, 0.27f, new DateTimeOffset(new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.85f, 30 },
                    { 19, "NO", null, 1.15f, null, new DateTimeOffset(new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.08f, 30 },
                    { 20, "DK", null, 0.133f, null, new DateTimeOffset(new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 21, "SE", null, 1.15f, 0.27f, new DateTimeOffset(new DateTime(2021, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 11, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.85f, 30 },
                    { 22, "SE", null, 1.15f, 0.32f, new DateTimeOffset(new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.85f, 30 },
                    { 23, "FI", null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 1, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 1, 31, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.36f, 30 },
                    { 24, "FI", null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 1, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 1, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.41f, 30 },
                    { 25, "FI", null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.41f, 30 },
                    { 26, "FI", null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 4, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.64f, 30 },
                    { 27, "NO", null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 5, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 31, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.08f, 30 },
                    { 28, "NO", null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.13f, 30 },
                    { 29, "FI", null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 8, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.64f, 30 },
                    { 30, "FI", null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 8, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f, 30 },
                    { 31, "SE", null, 1.15f, 0.32f, new DateTimeOffset(new DateTime(2022, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.85f, 30 },
                    { 32, "SE", null, 1.15f, 0.33f, new DateTimeOffset(new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.85f, 30 },
                    { 33, "FI", null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.7f, 30 },
                    { 34, "SE", null, 1.15f, 0.33f, new DateTimeOffset(new DateTime(2022, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.85f, 30 },
                    { 35, "SE", null, 1.15f, 0.33f, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f, 30 },
                    { 36, "FI", null, 1.15f, null, new DateTimeOffset(new DateTime(2023, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 4, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.7f, 30 },
                    { 37, "NO", null, 1.15f, null, new DateTimeOffset(new DateTime(2023, 5, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.13f, 30 },
                    { 38, "FI", null, 1.15f, null, new DateTimeOffset(new DateTime(2023, 5, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f, 30 },
                    { 39, "DK", null, 0.133f, null, new DateTimeOffset(new DateTime(2023, 5, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 40, "SE", null, 1.15f, 0.33f, new DateTimeOffset(new DateTime(2023, 5, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f, 30 },
                    { 41, "NO", 1.15f, null, null, new DateTimeOffset(new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.13f, 30 },
                    { 42, "SE", 1.15f, null, 0.33f, new DateTimeOffset(new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f, 30 },
                    { 43, "DK", 0.133f, null, null, new DateTimeOffset(new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 44, "FI", 1.15f, null, null, new DateTimeOffset(new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f, 30 },
                    { 45, "FI", 1.15f, null, null, new DateTimeOffset(new DateTime(2023, 10, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 31, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f, 30 },
                    { 46, "FI", 1.15f, null, null, new DateTimeOffset(new DateTime(2023, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.5f, 30 },
                    { 47, "SE", 1.15f, null, 0.33f, new DateTimeOffset(new DateTime(2023, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f, 30 },
                    { 48, "SE", 1.15f, null, 0.29f, new DateTimeOffset(new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f, 30 },
                    { 49, "NO", 1.15f, null, null, new DateTimeOffset(new DateTime(2023, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.13f, 30 },
                    { 50, "SE", 1.15f, null, 0.29f, new DateTimeOffset(new DateTime(2023, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f, 30 },
                    { 51, "SE", 1.15f, null, 0.29f, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.6f, 30 },
                    { 52, "NO", 1.15f, null, null, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.21f, 30 },
                    { 53, "FI", 1.15f, null, null, new DateTimeOffset(new DateTime(2024, 2, 29, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.5f, 30 },
                    { 54, "FI", 1.15f, null, null, new DateTimeOffset(new DateTime(2024, 2, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 29, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.33f, 30 },
                    { 55, "SE", 1.15f, null, 0.29f, new DateTimeOffset(new DateTime(2024, 9, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.6f, 30 },
                    { 56, "NO", 1.15f, null, null, new DateTimeOffset(new DateTime(2024, 9, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.21f, 30 },
                    { 57, "DK", 0.133f, null, null, new DateTimeOffset(new DateTime(2024, 9, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, 30 },
                    { 58, "FI", 1.15f, null, null, new DateTimeOffset(new DateTime(2024, 9, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.33f, 30 }
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
