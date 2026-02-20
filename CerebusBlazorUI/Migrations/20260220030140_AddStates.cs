using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CerebusBlazorUI.Migrations
{
    /// <inheritdoc />
    public partial class AddStates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "USStates",
                columns: new[] { "ID", "Abbreviation", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "AL", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(4971), false, false, "Alabama", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(4974) },
                    { 2, "AK", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5009), false, false, "Alaska", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5009) },
                    { 3, "AZ", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5012), false, false, "Arizona", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5013) },
                    { 4, "AR", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5015), false, false, "Arkansas", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5016) },
                    { 5, "CA", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5018), false, false, "California", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5019) },
                    { 6, "CO", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5021), false, false, "Colorado", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5021) },
                    { 7, "CT", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5024), false, false, "Connecticut", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5024) },
                    { 8, "DE", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5026), false, false, "Delaware", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5027) },
                    { 9, "FL", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5029), false, false, "Florida", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5030) },
                    { 10, "GA", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5032), false, false, "Georgia", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5032) },
                    { 11, "HI", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5034), false, false, "Hawaii", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5035) },
                    { 12, "ID", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5037), false, false, "Idaho", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5038) },
                    { 13, "IL", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5040), false, false, "Illinois", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5040) },
                    { 14, "IN", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5058), false, false, "Indiana", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5059) },
                    { 15, "IA", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5061), false, false, "Iowa", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5062) },
                    { 16, "KS", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5064), false, false, "Kansas", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5064) },
                    { 17, "KY", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5066), false, false, "Kentucky", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5067) },
                    { 18, "LA", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5069), false, false, "Louisiana", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5069) },
                    { 19, "ME", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5071), false, false, "Maine", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5072) },
                    { 20, "MD", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5074), false, false, "Maryland", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5074) },
                    { 21, "MA", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5077), false, false, "Massachusetts", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5077) },
                    { 22, "MI", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5079), false, false, "Michigan", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5079) },
                    { 23, "MN", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5082), false, false, "Minnesota", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5082) },
                    { 24, "MS", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5084), false, false, "Mississippi", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5085) },
                    { 25, "MO", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5087), false, false, "Missouri", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5087) },
                    { 26, "MT", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5103), false, false, "Montana", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5103) },
                    { 27, "NE", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5106), false, false, "Nebraska", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5106) },
                    { 28, "NV", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5109), false, false, "Nevada", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5109) },
                    { 29, "NH", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5111), false, false, "New Hampshire", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5112) },
                    { 30, "NJ", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5114), false, false, "New Jersey", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 507, DateTimeKind.Utc).AddTicks(5115) },
                    { 31, "NM", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6059), false, false, "New Mexico", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6060) },
                    { 32, "NY", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6072), false, false, "New York", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6072) },
                    { 33, "NC", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6075), false, false, "North Carolona", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6076) },
                    { 34, "ND", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6078), false, false, "North Dakota", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6079) },
                    { 35, "OH", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6081), false, false, "Ohio", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6082) },
                    { 36, "OK", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6085), false, false, "Oklahoma", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6085) },
                    { 37, "OR", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6142), false, false, "Oregon", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6143) },
                    { 38, "PA", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6146), false, false, "Pennsylvania", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6146) },
                    { 39, "RI", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6149), false, false, "Rhode Island", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6149) },
                    { 40, "SC", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6152), false, false, "South Carolina", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6153) },
                    { 41, "SD", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6156), false, false, "South Dakota", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6157) },
                    { 42, "TN", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6159), false, false, "Tennessee", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6160) },
                    { 43, "TX", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6162), false, false, "Texas", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6163) },
                    { 44, "UT", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6165), false, false, "Utah", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6166) },
                    { 45, "VT", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6168), false, false, "Vermont", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6168) },
                    { 46, "VA", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6171), false, false, "Virginia", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6171) },
                    { 47, "WA", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6174), false, false, "Washington", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6174) },
                    { 48, "WV", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6177), false, false, "West Virginia", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6177) },
                    { 49, "WI", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6180), false, false, "Wisconsin", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6180) },
                    { 50, "WY", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6183), false, false, "Wyoming", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6183) },
                    { 51, "DC", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6186), false, false, "District of Columbia", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6186) },
                    { 52, "PR", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6189), false, false, "Puerto Rico", "admin", new DateTime(2026, 2, 20, 3, 1, 39, 512, DateTimeKind.Utc).AddTicks(6189) }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "USStates",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                column: "Password",
                value: "AHDy/36nvmOIZZ+86saNDDFVoWZqPdMNLScwq3GykJc7AdtNYTTHXzchpD1KiIYQCQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                column: "Password",
                value: "ANAQW4iT7s3qS+WVncAjgo2la5Zl6EzwzRq2+SSITTQ0nUfilTUofxltn3FDAvoS2w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3,
                column: "Password",
                value: "AFI2Nd6dJGY0lKl0gJiBstFZBaUcxaubVUYRtwKKARvO1jfOpNLgHXm6C4qupJE1RA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4,
                column: "Password",
                value: "AFo2tWOviyiD7tNSlTU6UNvyrUd6TZ2M5ukl09kV9ZQlr+u5Es8SQSsrw/U1Qr045w==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5,
                column: "Password",
                value: "ABuDZTAUpBfjClDnBbuTqsO2Ohw3wZnl6eY2Uhk8Ftxgb1PnxEBj2C+27yaFhDYIYQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 6,
                column: "Password",
                value: "ABtVwICrTLu8knP/WNfm7usNsC7VExgFjDM6ojcDf0/hOzg+mDF5m8d9tXebXdeedg==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 7,
                column: "Password",
                value: "ADQ9bxzIYuZeQLSJ5x69PiEYOoIsAOAC8sUM0tMj6eY3BVRE3VTNhzXfFto1mZT1kA==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 8,
                column: "Password",
                value: "APtnb0sr2RybmObY29ntYRk2frFJPhuyySDWoPeuu/Mgu7SzaFvW/cgs5rrGC0T9PQ==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 9,
                column: "Password",
                value: "ADVBZqOGXLWjgWiQWJR0ZRWnae4cjVGUw4gjiUs+e95eHHplxfQpohqBPZflleZjLw==");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 10,
                column: "Password",
                value: "AKy6UXrnR3wdQ5PqaRb+i8HjNdFAragkOvsiARH436549gWB+buaIrv5H9dW1ymgiQ==");
        }
    }
}
