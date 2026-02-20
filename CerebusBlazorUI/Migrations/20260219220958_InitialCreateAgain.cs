using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CerebusBlazorUI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    MiddleNameOrInitial = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    EmailAddress = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    StreetAddress = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    ZipCode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "City", "CreatedBy", "CreatedDate", "EmailAddress", "FirstName", "HireDate", "IsActive", "IsDeleted", "LastName", "MiddleNameOrInitial", "Password", "PhoneNumber", "State", "StreetAddress", "TerminationDate", "Title", "UpdatedBy", "UpdatedDate", "Username", "ZipCode" },
                values: new object[,]
                {
                    { 1, "New York", "admin", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob.Reed@Cerebus.fake", "Bob", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Reed", "L", "AGdJ7cEMf/eMJjFLE6gA7Y3s5hLAcQM1HlJPuBCfRtON2h3FX8kXAwSIMKe2i/BsCg==", "646-555-3047", "32", "814 Geraldine Lane", null, "CEO", "admin", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob.Reed", "10011" },
                    { 2, "Buffalo", "admin", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latoya.Carter@Cerebus.fake", "Latoya", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Carter", "N", "AIZxZbZ4vykUJqPVDHsrlnEx9F2/D9fF6f7iWSfizxo+rLuAroeE1c75WCGpdvcYNA==", "716-555-3630", "32", "2034 Jarvis Street", null, "HR Generalist", "admin", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latoya.Carter", "14222" },
                    { 3, "Cambridge", "admin", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua.Boyer@Cerebus.fake", "Joshua", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Boyer", "O", "ALx8TAQU7FISU230Hx9lvVEtE7z9nk2D4x+Zv4bKYyo292Cba/peN0AFWEt6EI+ZyA==", "508-555-2320", "21", "3821 Randolph Street", null, "IT Director", "admin", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua.Boyer", "02141" },
                    { 4, "New York", "admin", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandy.William@Cerebus.fake", "Sandy", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "William", "E", "AMmtwHAzQ64Rk3d2ylZqvD08BPPYdt8Pl8RNHarqbfrlPK1jlQeRyf03QBvGsPOi9w==", "212-555-3480", "32", "35 Godfrey Road", null, "Systems Administrator", "admin", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandy.William", "10022" },
                    { 5, "Hartford", "admin", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher.Cross@Cerebus.fake", "Christopher", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Cross", "U", "AKVsSTrqrpT4qtYkPE5m5CAnDHV++M9IvnPiWti5fqNeW7K8ELuLcRYhsSiVZ8QGCQ==", "860-555-0200", "7", "459 Hart Street", null, "IT Technician", "admin", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher.Cross", "06103" },
                    { 6, "Albany", "admin", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trevor.Ryan@Cerebus.fake", "Trevor", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ryan", "M", "AOXjkLu2vAYgT4p7S5z0K9NxPRNVor6X9rIcgiBOgCB61IIoQizXkHhU2Ub7oerVfA==", "518-555-2034", "32", "3564 Hardesty Street", null, "IT Technician", "admin", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trevor.Ryan", "12207" },
                    { 7, "Andover", "admin", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arlene.Dawson@Cerebus.fake", "Arlene", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Dawson", "R", "ABdrcyVjZIOoS6PXfbSo6AofSbXtSyrOsXZ5flf2KyqrytPF7WSllwgfTwzT5f2IKQ==", "207-555-2113", "19", "262 Victoria Court", null, "Software Developer", "admin", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arlene.Dawson", "04216" },
                    { 8, "Clarion", "admin", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna.Hartman@Cerebus.fake", "Anna", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Hartman", "A", "AEDH5LgFllFE37M6eCgGRWPi5UgkNALjjSWLOnBCYSh/7Ti2xWsZNa/yLOU0vUUG6w==", "814-555-1968", "38", "2797 Coal Street", null, "Customer Service Manager", "admin", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna.Hartman", "16214" },
                    { 9, "Millington", "admin", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janette.James@Cerebus.fake", "Janette", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "James", "W", "AD7hgMHfg6Elmt9dyWFYtNfz92WMeUKVKmL5uiwmwXk22m7oK33Wc6mK0ipX5aVfJQ==", "908-555-4192", "30", "1198 Hedge Street", null, "Customer Service Representative", "admin", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janette.James", "07946" },
                    { 10, "Syracuse", "admin", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Van.Harmon@Cerebus.fake", "Van", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Harmon", "T", "AOswojxYsUlH2i5O36r2czDDFvRpC2EQk+hjHI4nbQVyj6Aa0Ou3GM+92Tum6nR9Kw==", "315-555-7346", "32", "1698 Saint Marys Avenue", null, "Customer Service Representative", "admin", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Van.Harmon", "13221" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
