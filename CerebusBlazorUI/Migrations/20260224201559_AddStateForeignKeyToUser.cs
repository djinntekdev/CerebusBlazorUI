using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CerebusBlazorUI.Migrations
{
    /// <inheritdoc />
    public partial class AddStateForeignKeyToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "USStateID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8109), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8118), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8149), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8154), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8157), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8160), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8164), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8167), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8170), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8174), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8177), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8180), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8183), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8186), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8209), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8213), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8216), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8219), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8222), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8225), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8229), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8232), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8235), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8238), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8239) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8242), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8245), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8267), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8270), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8273), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8276), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8279), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8282), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8285), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8288), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8291), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8294), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8297), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8315), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8319), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8322), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8326), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8329), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8332), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8363), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8367), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8370), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8373), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8376), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8379), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8382), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8383) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8385), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8389), new DateTime(2026, 2, 24, 20, 15, 58, 310, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Password", "USStateID" },
                values: new object[] { "AKH+3tDerSVGjhVbP8SZH5sjV0322crmA7kVSyO8R/27jVIiwvpfdcN+0MTD8TsBmw==", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Password", "USStateID" },
                values: new object[] { "AJXWpzUAuRZAmtyZ9oUEGQ2NO/BZHSSlKBqeVZwkMtSBru64qVmIF17+hb4n3r7hhA==", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Password", "USStateID" },
                values: new object[] { "AKIXV3/R+gQXqTfwmIHVuID2q2l/6V2ld4RYXDikqZLkknwSJtGVd5SoKQWi5FnzBA==", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Password", "USStateID" },
                values: new object[] { "AAdp4SWloi37g1kbKmOOI+HTZp2VA34qhBYENzryNAWywuvmy4mr7SMBaxkAL8OdTA==", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Password", "USStateID" },
                values: new object[] { "AGrlV6mXKpkETmyuFoM9WGtvjU7B1LHumC9T8LF+2++p+LjL0fyFI6rYNlahcIkSUw==", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Password", "USStateID" },
                values: new object[] { "ACPHQhZpTpqVLD2x9wt8yOxCn+MLvSYMkTbSCClUf/ZWWuYr0syzC2Uj6cnMUxelCw==", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Password", "USStateID" },
                values: new object[] { "AK0WsFSQKaspM+quZP+aHsg7+KB5WeQgZqvB2tuK+X9VDqB5KaH9xsJMub1HdD2t4g==", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Password", "USStateID" },
                values: new object[] { "AGI6/IWblm10FIeUIsmi6omtgxDnHLLbXKXuSwbHX5cXTzgDhMYXCQyQQj+LAALzJg==", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Password", "USStateID" },
                values: new object[] { "APD0ViYfX3fMQBekx2BefgBwoagAlTWdkCflOHkB5IiU/fTIPX9PsZbLUQmEXMScIw==", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Password", "USStateID" },
                values: new object[] { "ANLNjglkmVgYNj/LiLTbw+RPDO8B87Gkz8tMM46ae25TlMPEvocQ4NHweu3TT6/EhQ==", 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Users_USStateID",
                table: "Users",
                column: "USStateID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_USStates_USStateID",
                table: "Users",
                column: "USStateID",
                principalTable: "USStates",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_USStates_USStateID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_USStateID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "USStateID",
                table: "Users");

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
