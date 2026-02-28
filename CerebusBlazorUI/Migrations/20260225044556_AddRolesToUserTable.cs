using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CerebusBlazorUI.Migrations
{
    /// <inheritdoc />
    public partial class AddRolesToUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserRoleID",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(318), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(327), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(366), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(370), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(400), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(403), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(406), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(410), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(412), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(415), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(416) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(418), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(421), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(424), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(428), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(447), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(451), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(454), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(457), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(460), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(463), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(466), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(468), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(472), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(475), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(478), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(495), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(499), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(502), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(505), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(508), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(511), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(514), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(518), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(521), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(523), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(527), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(530), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(549), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(552), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(555), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(558), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(561), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(565), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(568), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(571), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(574), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(577), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(580), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(583), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(586), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(589), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(593), new DateTime(2026, 2, 25, 4, 45, 55, 786, DateTimeKind.Utc).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Password", "UserRoleID" },
                values: new object[] { "ABS2e8suAA58lnAgxStc38zZiRD1fN4pF7ZSYwtjzOLsOaZqbpr29g8JZMq4GObADw==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Password", "UserRoleID" },
                values: new object[] { "AKtzUvBWBn+Sg5jCj1agsunib4N566147AXhKPa30sVKxvCD+a/xgRS6VNyvVaEHpg==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Password", "UserRoleID" },
                values: new object[] { "AOvBpO6wdmQTctwHbiSUuE6NKurNG35vvm4q7IrP38+WW0I5eOtt/AJXVaDXnRE4sw==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Password", "UserRoleID" },
                values: new object[] { "AOQvS/G+5whijuPyWw8uW8SOp2VSJYzOOL6Q6MALJsFhDpkrad9ClguO7BzTIoEHng==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Password", "UserRoleID" },
                values: new object[] { "AIQCYjN+7Kzrut8ERzCI40nbVeK9JsGrxBCpjrkY8sbp3d13aE1JgnoDDTPwZfcSIg==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Password", "UserRoleID" },
                values: new object[] { "AKsFXFd/2yxhoA+W7WobwVhRx4+wZCEYSWyb92Br6FaYKHdIYAvtpqkDFlfpTGgpZA==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Password", "UserRoleID" },
                values: new object[] { "ACvTDqVwZqhzQ5aScLrj/7szQLRmPR5rTDoepjnBmQqr0KjEGfzDjqN8DKv/63jUHA==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Password", "UserRoleID" },
                values: new object[] { "AM6g1h26j3fQ0ARDANy+cL2iNrf/jj6Hsg5yrzUR7D2pnWQaUKiWYYH7NMR1Yvt05g==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Password", "UserRoleID" },
                values: new object[] { "AKi1RecmcToV0rH1R6k6PLxQmEhxMcSJeVAqctvL8pLpukrfdhk/QOj+8bABuHkn/Q==", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Password", "UserRoleID" },
                values: new object[] { "AIGfpfiLzE2VZv9ARsv66KtHXS7TqcCwa0ky6Sz50KQzVDsCLPzdOjCq8yWn/iOLSw==", null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserRoleID",
                table: "Users",
                column: "UserRoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_UserRoleID",
                table: "Users",
                column: "UserRoleID",
                principalTable: "UserRoles",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_UserRoleID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserRoleID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserRoleID",
                table: "Users");

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
    }
}
