using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CerebusBlazorUI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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

            migrationBuilder.CreateTable(
                name: "USStates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Abbreviation = table.Column<string>(type: "longtext", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USStates", x => x.ID);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "City", "CreatedBy", "CreatedDate", "EmailAddress", "FirstName", "HireDate", "IsActive", "IsDeleted", "LastName", "MiddleNameOrInitial", "Password", "PhoneNumber", "State", "StreetAddress", "TerminationDate", "Title", "UpdatedBy", "UpdatedDate", "Username", "ZipCode" },
                values: new object[,]
                {
                    { 1, "New York", "admin", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob.Reed@Cerebus.fake", "Bob", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Reed", "L", "AHDy/36nvmOIZZ+86saNDDFVoWZqPdMNLScwq3GykJc7AdtNYTTHXzchpD1KiIYQCQ==", "646-555-3047", "32", "814 Geraldine Lane", null, "CEO", "admin", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob.Reed", "10011" },
                    { 2, "Buffalo", "admin", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latoya.Carter@Cerebus.fake", "Latoya", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Carter", "N", "ANAQW4iT7s3qS+WVncAjgo2la5Zl6EzwzRq2+SSITTQ0nUfilTUofxltn3FDAvoS2w==", "716-555-3630", "32", "2034 Jarvis Street", null, "HR Generalist", "admin", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latoya.Carter", "14222" },
                    { 3, "Cambridge", "admin", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua.Boyer@Cerebus.fake", "Joshua", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Boyer", "O", "AFI2Nd6dJGY0lKl0gJiBstFZBaUcxaubVUYRtwKKARvO1jfOpNLgHXm6C4qupJE1RA==", "508-555-2320", "21", "3821 Randolph Street", null, "IT Director", "admin", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua.Boyer", "02141" },
                    { 4, "New York", "admin", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandy.William@Cerebus.fake", "Sandy", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "William", "E", "AFo2tWOviyiD7tNSlTU6UNvyrUd6TZ2M5ukl09kV9ZQlr+u5Es8SQSsrw/U1Qr045w==", "212-555-3480", "32", "35 Godfrey Road", null, "Systems Administrator", "admin", new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandy.William", "10022" },
                    { 5, "Hartford", "admin", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher.Cross@Cerebus.fake", "Christopher", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Cross", "U", "ABuDZTAUpBfjClDnBbuTqsO2Ohw3wZnl6eY2Uhk8Ftxgb1PnxEBj2C+27yaFhDYIYQ==", "860-555-0200", "7", "459 Hart Street", null, "IT Technician", "admin", new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher.Cross", "06103" },
                    { 6, "Albany", "admin", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trevor.Ryan@Cerebus.fake", "Trevor", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Ryan", "M", "ABtVwICrTLu8knP/WNfm7usNsC7VExgFjDM6ojcDf0/hOzg+mDF5m8d9tXebXdeedg==", "518-555-2034", "32", "3564 Hardesty Street", null, "IT Technician", "admin", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trevor.Ryan", "12207" },
                    { 7, "Andover", "admin", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arlene.Dawson@Cerebus.fake", "Arlene", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Dawson", "R", "ADQ9bxzIYuZeQLSJ5x69PiEYOoIsAOAC8sUM0tMj6eY3BVRE3VTNhzXfFto1mZT1kA==", "207-555-2113", "19", "262 Victoria Court", null, "Software Developer", "admin", new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arlene.Dawson", "04216" },
                    { 8, "Clarion", "admin", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna.Hartman@Cerebus.fake", "Anna", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Hartman", "A", "APtnb0sr2RybmObY29ntYRk2frFJPhuyySDWoPeuu/Mgu7SzaFvW/cgs5rrGC0T9PQ==", "814-555-1968", "38", "2797 Coal Street", null, "Customer Service Manager", "admin", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna.Hartman", "16214" },
                    { 9, "Millington", "admin", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janette.James@Cerebus.fake", "Janette", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "James", "W", "ADVBZqOGXLWjgWiQWJR0ZRWnae4cjVGUw4gjiUs+e95eHHplxfQpohqBPZflleZjLw==", "908-555-4192", "30", "1198 Hedge Street", null, "Customer Service Representative", "admin", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janette.James", "07946" },
                    { 10, "Syracuse", "admin", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Van.Harmon@Cerebus.fake", "Van", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, "Harmon", "T", "AKy6UXrnR3wdQ5PqaRb+i8HjNdFAragkOvsiARH436549gWB+buaIrv5H9dW1ymgiQ==", "315-555-7346", "32", "1698 Saint Marys Avenue", null, "Customer Service Representative", "admin", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Van.Harmon", "13221" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "USStates");
        }
    }
}
