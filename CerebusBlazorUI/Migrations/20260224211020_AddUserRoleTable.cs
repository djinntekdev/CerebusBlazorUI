using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace CerebusBlazorUI.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRoleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    IsAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsManager = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.ID);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9917), new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9925), new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9928), new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9931), new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9962), new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9965), new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9968), new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9971), new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9974), new DateTime(2026, 2, 24, 21, 10, 19, 348, DateTimeKind.Utc).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(8), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(12), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(15), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(17), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(21), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(24), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(27), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(30), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(33), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(33) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(35), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(38), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(41), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(58), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(61), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(64), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(67), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(70), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(73), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(76), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(79), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(81), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(84), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(85) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(87), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(90), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(106), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(109), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(112), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(115), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(118), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(120), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(123), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(126), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(129), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(132), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(135), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(138), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(140), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(143), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(146), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(149), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(151), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(154), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(155) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(157), new DateTime(2026, 2, 24, 21, 10, 19, 349, DateTimeKind.Utc).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "Password",
                value: "AM25rfn498HhSwjEwCgpnnXZGfmvMbdmp1R/gdZrpMMrIidHDSZ5Y7XwMJtR5g6SKg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "Password",
                value: "AG07dIPyxsLdWzuyimzTiDgRQuKNjVYhrI7h4gOEF44css3vDE+gtRNBFItDeH7x1w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                column: "Password",
                value: "AEkBh5o8HQlvRLo8Qau5U6Rx9fz980ifzZyLjsJ1Hv4DAI8rp193d9tofiLHZdEHEg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                column: "Password",
                value: "AHwSwAVpdIw/iyomRgpYKeA0M39/sJtJhWlEp3BroWjV8tS4oC4WVEAHMeLUF1ABsQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                column: "Password",
                value: "AKBsiXg5u9k+egRFlltrlsCpwQOFMHclovvhfe1m3aYkURCLuXBD20qhseIywSoqCA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 6,
                column: "Password",
                value: "AAMClsiMmi7Owm+pD2iD8ZZkXpv9FvcNd16jgzuUuzshwwc2EKCjEbZ4wJhEQ8AFLQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 7,
                column: "Password",
                value: "AFbewvagJch2bMDVEsA+f43ZGGOTHd2ThZUbyMNHzfmahpvN16eY09oDfi0OsLmrZA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 8,
                column: "Password",
                value: "AD0BjkmEDliraWhIW6yrv8nYb1YafYy2f16K9C6YDioa9XIds/hQ5obJNWiZIA00hA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 9,
                column: "Password",
                value: "ACXX7jLhQoMmT1zqz7a8RCNEjetvJzw2fEN4Hp4uPtKCkqz9o8czoBe2Uxq0ZRfYSQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 10,
                column: "Password",
                value: "APsU4dqJry6dGFirAR4LnkLfrx/LiKFfcZmLvtRYPnpjbt0ClkLrHSPvZ2jObIFxHA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(4971), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5009), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5012), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5015), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5018), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5021), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5024), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5026), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5029), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5032), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5034), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5037), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5040), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5058), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5061), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5064), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5066), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5069), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5071), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5074), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5077), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5079), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5082), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5084), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5087), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5103), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5106), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5109), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5111), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5114), new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6059), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6072), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6075), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6078), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6081), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6085), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6142), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6146), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6149), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6152), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6156), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6159), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6162), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6165), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6168), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6171), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6174), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6177), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6180), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6183), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6186), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6189), new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "Password",
                value: "AHRoHFuSN14WPgLpdm/5sGdh0GjmPJegCVSyzTpJIqYc3mQJTvrDwgqqiyWau5qBkQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "Password",
                value: "APHxbsLp4xTnlOvRw17p6nM0ylvuKtiNUbJc9AYiSUpbR2Lttj7aa9CHkubk8EShLw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                column: "Password",
                value: "ADYrcpQROhC+kFR7VsqwvhMcs87KKQCvRghg0rCacKryRet+DVSihvrmgyye+zkPLQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                column: "Password",
                value: "AKTusS+Q0O2mAJYM32BYzeF93P0FnxgMbq/R1nloiGm5DBS+EAaR5SvZk1nIbe2+OA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                column: "Password",
                value: "APZozU0Y2NQsegcAtt8bAArDsnxmfqlrvV3gHIab23vfA3f/7NwIPGnPxgC/kHPONA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 6,
                column: "Password",
                value: "AGqDayCJRl1HE2fDbeAmBguFhrD4eiCBn+x665lR/P8Wl2JFezl982/mdgOhGgONTw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 7,
                column: "Password",
                value: "AP68XrJHalXtdwcFwNFNhu23g/12Jg1tMtaMhbNZuIcwex5OTf11fHA1Im/MMLgJYQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 8,
                column: "Password",
                value: "AEpSHTogjKMFhZ2e8XkzJCgosUWq9wPciYf98eO/xl+1CWtClDvsXVy9RbdKSEaKpQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 9,
                column: "Password",
                value: "AL+xGbePile7fZHqCJNCbsX6nYktE+npt6DvKt+w5EoAO4Ttc0UE04YMmQTutRYlbA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 10,
                column: "Password",
                value: "AImU1FPqP/A4NPLkhoKeDvyZY6Xq4/cCjJMgw1LUv3LhHOSkhMRgrJNnLCLeMXWV8w==");
        }
    }
}
