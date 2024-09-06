using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI_MVC_ASR.Migrations
{
    /// <inheritdoc />
    public partial class actualizacionTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "VolumeFee",
                table: "Feeds",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TimestampUTC",
                table: "Feeds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<string>(
                name: "Timestamp",
                table: "Feeds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<decimal>(
                name: "PeakLoadFee",
                table: "Feeds",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ImbalanceFee",
                table: "Feeds",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "HourlyImbalanceFee",
                table: "Feeds",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, "2017-05-01T00:00:00", "2017-04-30T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, "2017-05-01T00:00:00", "2017-04-30T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.43m, "2017-05-01T00:00:00", "2017-04-30T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, "2017-05-01T00:00:00", "2017-04-30T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.43m, "2018-11-15T23:00:00", "2018-11-15T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.35m, "2018-11-16T00:00:00", "2018-11-15T23:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.35m, "2019-11-15T23:00:00", "2019-11-15T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.31m, "2019-11-16T00:00:00", "2019-11-15T23:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.31m, "2020-11-15T23:00:00", "2020-11-15T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.27m, "2020-11-16T00:00:00", "2020-11-15T23:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, "2021-01-31T23:00:00", "2021-01-31T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, "2021-02-01T00:00:00", "2021-01-31T23:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.27m, "2021-10-31T23:00:00", "2021-10-31T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, "2021-10-31T23:00:00", "2021-10-31T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, "2021-10-31T23:00:00", "2021-10-31T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, "2021-10-31T23:00:00", "2021-10-31T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2021-11-01T00:00:00", "2021-10-31T23:00:00Z", 0.36m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, 0.27m, "2021-11-01T00:00:00", "2021-10-31T23:00:00Z", 0.85m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2021-11-01T00:00:00", "2021-10-31T23:00:00Z", 0.08m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 0.133m, null, "2021-11-01T00:00:00", "2021-10-31T23:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, 0.27m, "2021-11-15T23:00:00", "2021-11-15T22:00:00Z", 0.85m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, 0.32m, "2021-11-16T00:00:00", "2021-11-15T23:00:00Z", 0.85m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2022-01-31T22:00:00", "2022-01-31T21:00:00Z", 0.36m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2022-01-31T23:00:00", "2022-01-31T22:00:00Z", 0.41m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2022-04-30T22:00:00", "2022-04-30T20:00:00Z", 0.41m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2022-04-30T23:00:00", "2022-04-30T21:00:00Z", 0.64m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2022-05-31T23:00:00", "2022-05-31T21:00:00Z", 0.08m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2022-06-01T00:00:00", "2022-05-31T22:00:00Z", 0.13m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2022-08-31T22:00:00", "2022-08-31T20:00:00Z", 0.64m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2022-08-31T23:00:00", "2022-08-31T21:00:00Z", 1.2m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, 0.32m, "2022-11-15T23:00:00", "2022-11-15T22:00:00Z", 0.85m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, 0.33m, "2022-11-16T00:00:00", "2022-11-15T23:00:00Z", 0.85m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2022-12-31T23:00:00", "2022-12-31T22:00:00Z", 1.7m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, 0.33m, "2022-12-31T23:00:00", "2022-12-31T22:00:00Z", 0.85m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, 0.33m, "2023-01-01T00:00:00", "2022-12-31T23:00:00Z", 1.2m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2023-04-30T22:00:00", "2023-04-30T20:00:00Z", 1.7m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2023-05-21T23:00:00", "2023-05-21T21:00:00Z", 0.13m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, null, "2023-05-21T23:00:00", "2023-05-21T21:00:00Z", 1.2m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 0.133m, null, "2023-05-21T23:00:00", "2023-05-21T21:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15m, 0.33m, "2023-05-21T23:00:00", "2023-05-21T21:00:00Z", 1.2m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, null, "2023-06-01T00:00:00", "2023-05-31T22:00:00Z", 0.13m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, 0.33m, "2023-06-01T00:00:00", "2023-05-31T22:00:00Z", 1.2m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 0.133m, null, null, "2023-06-01T00:00:00", "2023-05-31T22:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, null, "2023-06-01T00:00:00", "2023-05-31T22:00:00Z", 1.2m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, null, "2023-10-31T22:00:00", "2023-10-31T21:00:00Z", 1.2m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, null, "2023-10-31T23:00:00", "2023-10-31T22:00:00Z", 1.5m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, 0.33m, "2023-11-15T23:00:00", "2023-11-15T22:00:00Z", 1.2m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, 0.29m, "2023-11-16T00:00:00", "2023-11-15T23:00:00Z", 1.2m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, null, "2023-12-31T23:00:00", "2023-12-31T22:00:00Z", 0.13m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, 0.29m, "2023-12-31T23:00:00", "2023-12-31T22:00:00Z", 1.2m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, 0.29m, "2024-01-01T00:00:00", "2023-12-31T23:00:00Z", 1.6m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, null, "2024-01-01T00:00:00", "2023-12-31T23:00:00Z", 0.21m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, null, "2024-02-29T22:00:00", "2024-02-29T21:00:00Z", 1.5m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, null, "2024-02-29T23:00:00", "2024-02-29T22:00:00Z", 1.33m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, 0.29m, "2024-09-01T23:00:00", "2024-09-01T21:00:00Z", 1.6m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, null, "2024-09-01T23:00:00", "2024-09-01T21:00:00Z", 0.21m });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 0.133m, null, null, "2024-09-01T23:00:00", "2024-09-01T21:00:00Z", null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15m, null, null, "2024-09-01T23:00:00", "2024-09-01T21:00:00Z", 1.33m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "VolumeFee",
                table: "Feeds",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "TimestampUTC",
                table: "Feeds",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Timestamp",
                table: "Feeds",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "PeakLoadFee",
                table: "Feeds",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "ImbalanceFee",
                table: "Feeds",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "HourlyImbalanceFee",
                table: "Feeds",
                type: "real",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, new DateTimeOffset(new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2017, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, new DateTimeOffset(new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2017, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.43f, new DateTimeOffset(new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2017, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, new DateTimeOffset(new DateTime(2017, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2017, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.43f, new DateTimeOffset(new DateTime(2018, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 11, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.35f, new DateTimeOffset(new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2018, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.35f, new DateTimeOffset(new DateTime(2019, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2019, 11, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.31f, new DateTimeOffset(new DateTime(2019, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2019, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.31f, new DateTimeOffset(new DateTime(2020, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.27f, new DateTimeOffset(new DateTime(2020, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2020, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, new DateTimeOffset(new DateTime(2021, 1, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, new DateTimeOffset(new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 1, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, 0.27f, new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, null, null, new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.36f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, 0.27f, new DateTimeOffset(new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.85f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.08f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 0.133f, null, new DateTimeOffset(new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, 0.27f, new DateTimeOffset(new DateTime(2021, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 11, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.85f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, 0.32f, new DateTimeOffset(new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.85f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 1, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 1, 31, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.36f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 1, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 1, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.41f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.41f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 4, 30, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 30, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.64f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 5, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 31, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.08f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 5, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.13f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 8, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.64f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 8, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 31, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, 0.32f, new DateTimeOffset(new DateTime(2022, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.85f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, 0.33f, new DateTimeOffset(new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.85f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2022, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.7f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, 0.33f, new DateTimeOffset(new DateTime(2022, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.85f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, 0.33f, new DateTimeOffset(new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2023, 4, 30, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 4, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.7f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2023, 5, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.13f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, null, new DateTimeOffset(new DateTime(2023, 5, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 0.133f, null, new DateTimeOffset(new DateTime(2023, 5, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { null, 1.15f, 0.33f, new DateTimeOffset(new DateTime(2023, 5, 21, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, null, new DateTimeOffset(new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.13f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, 0.33f, new DateTimeOffset(new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 0.133f, null, null, new DateTimeOffset(new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, null, new DateTimeOffset(new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 5, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, null, new DateTimeOffset(new DateTime(2023, 10, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 31, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, null, new DateTimeOffset(new DateTime(2023, 10, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.5f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, 0.33f, new DateTimeOffset(new DateTime(2023, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, 0.29f, new DateTimeOffset(new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, null, new DateTimeOffset(new DateTime(2023, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.13f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, 0.29f, new DateTimeOffset(new DateTime(2023, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 31, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.2f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, 0.29f, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.6f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, null, new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 12, 31, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.21f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, null, new DateTimeOffset(new DateTime(2024, 2, 29, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 29, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.5f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, null, new DateTimeOffset(new DateTime(2024, 2, 29, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 29, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.33f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, 0.29f, new DateTimeOffset(new DateTime(2024, 9, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.6f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, null, new DateTimeOffset(new DateTime(2024, 9, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 0.21f });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 0.133f, null, null, new DateTimeOffset(new DateTime(2024, 9, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "HourlyImbalanceFee", "ImbalanceFee", "PeakLoadFee", "Timestamp", "TimestampUTC", "VolumeFee" },
                values: new object[] { 1.15f, null, null, new DateTimeOffset(new DateTime(2024, 9, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 9, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1.33f });
        }
    }
}
