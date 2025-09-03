using System;
using CerebusBlazorUI.Classes.Places;
using CerebusBlazorUI.Classes.User;
using Microsoft.EntityFrameworkCore;

namespace CerebusBlazorUI.Utilities.Entity;

public static class Seeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        SeedUsers(modelBuilder);
        //(modelBuilder);
    }

    private static void SeedUsers(ModelBuilder modelBuilder)
    {
        try
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    FirstName = "Bob",
                    LastName = "Reed",
                    MiddleNameOrInitial = "L",
                    Username = "Bob.Reed",
                    Password = Encryptor.HashPasswordV2("GoCerebus99"),
                    EmailAddress = "Bob.Reed@Cerebus.fake",
                    PhoneNumber = "646-555-3047",
                    StreetAddress = "814 Geraldine Lane",
                    City = "New York",
                    State = ((int)USStates.NY).ToString(),
                    ZipCode = "10011",
                    Title = "CEO",
                    HireDate = new DateTime(2020, 1, 15),
                    TerminationDate = null,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = new DateTime(2020, 1, 15),
                    UpdatedDate = new DateTime(2020, 1, 15)
                },
                new User
                {
                    ID = 2,
                    FirstName = "Latoya",
                    LastName = "Carter",
                    MiddleNameOrInitial = "N",
                    Username = "Latoya.Carter",
                    Password = Encryptor.HashPasswordV2("HelloKitty85"),
                    EmailAddress = "Latoya.Carter@Cerebus.fake",
                    PhoneNumber = "716-555-3630",
                    StreetAddress = "2034 Jarvis Street",
                    City = "Buffalo",
                    State = ((int)USStates.NY).ToString(),
                    ZipCode = "14222",
                    Title = "HR Generalist",
                    HireDate = new DateTime(2021, 5, 5),
                    TerminationDate = null,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = new DateTime(2021, 5, 5),
                    UpdatedDate = new DateTime(2021, 5, 5)
                },
                new User
                {
                    ID = 3,
                    FirstName = "Joshua",
                    LastName = "Boyer",
                    MiddleNameOrInitial = "O",
                    Username = "Joshua.Boyer",
                    Password = Encryptor.HashPasswordV2("GoBills2025"),
                    EmailAddress = "Joshua.Boyer@Cerebus.fake",
                    PhoneNumber = "508-555-2320",
                    StreetAddress = "3821 Randolph Street",
                    City = "Cambridge",
                    State = ((int)USStates.MA).ToString(),
                    ZipCode = "02141",
                    Title = "IT Director",
                    HireDate = new DateTime(2021, 2, 25),
                    TerminationDate = null,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = new DateTime(2021, 2, 25),
                    UpdatedDate = new DateTime(2021, 2, 25)
                },
                new User
                {
                    ID = 4,
                    FirstName = "Sandy",
                    LastName = "William",
                    MiddleNameOrInitial = "E",
                    Username = "Sandy.William",
                    Password = Encryptor.HashPasswordV2("HodlCrypto99"),
                    EmailAddress = "Sandy.William@Cerebus.fake",
                    PhoneNumber = "212-555-3480",
                    StreetAddress = "35 Godfrey Road",
                    City = "New York",
                    State = ((int)USStates.NY).ToString(),
                    ZipCode = "10022",
                    Title = "Systems Administrator",
                    HireDate = new DateTime(2023, 8, 1),
                    TerminationDate = null,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = new DateTime(2023, 8, 1),
                    UpdatedDate = new DateTime(2023, 8, 1)
                },
                new User
                {
                    ID = 5,
                    FirstName = "Christopher",
                    LastName = "Cross",
                    MiddleNameOrInitial = "U",
                    Username = "Christopher.Cross",
                    Password = Encryptor.HashPasswordV2("RedWolf33"),
                    EmailAddress = "Christopher.Cross@Cerebus.fake",
                    PhoneNumber = "860-555-0200",
                    StreetAddress = "459 Hart Street",
                    City = "Hartford",
                    State = ((int)USStates.CT).ToString(),
                    ZipCode = "06103",
                    Title = "IT Technician",
                    HireDate = new DateTime(2023, 4, 15),
                    TerminationDate = null,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = new DateTime(2023, 4, 15),
                    UpdatedDate = new DateTime(2023, 4, 15)
                },
                new User
                {
                    ID = 6,
                    FirstName = "Trevor",
                    LastName = "Ryan",
                    MiddleNameOrInitial = "M",
                    Username = "Trevor.Ryan",
                    Password = Encryptor.HashPasswordV2("HackYou00"),
                    EmailAddress = "Trevor.Ryan@Cerebus.fake",
                    PhoneNumber = "518-555-2034",
                    StreetAddress = "3564 Hardesty Street",
                    City = "Albany",
                    State = ((int)USStates.NY).ToString(),
                    ZipCode = "12207",
                    Title = "IT Technician",
                    HireDate = new DateTime(2024, 9, 30),
                    TerminationDate = null,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = new DateTime(2024, 9, 30),
                    UpdatedDate = new DateTime(2024, 9, 30)
                },
                new User
                {
                    ID = 7,
                    FirstName = "Arlene",
                    LastName = "Dawson",
                    MiddleNameOrInitial = "R",
                    Username = "Arlene.Dawson",
                    Password = Encryptor.HashPasswordV2("WinterIsComing99"),
                    EmailAddress = "Arlene.Dawson@Cerebus.fake",
                    PhoneNumber = "207-555-2113",
                    StreetAddress = "262 Victoria Court",
                    City = "Andover",
                    State = ((int)USStates.ME).ToString(),
                    ZipCode = "04216",
                    Title = "Software Developer",
                    HireDate = new DateTime(2023, 12, 15),
                    TerminationDate = null,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = new DateTime(2023, 12, 15),
                    UpdatedDate = new DateTime(2023, 12, 15)
                },
                new User
                {
                    ID = 8,
                    FirstName = "Anna",
                    LastName = "Hartman",
                    Username = "Anna.Hartman",
                    MiddleNameOrInitial = "A",
                    Password = Encryptor.HashPasswordV2("WhyOhhWhy10"),
                    EmailAddress = "Anna.Hartman@Cerebus.fake",
                    PhoneNumber = "814-555-1968",
                    StreetAddress = "2797 Coal Street",
                    City = "Clarion",
                    State = ((int)USStates.PA).ToString(),
                    ZipCode = "16214",
                    Title = "Customer Service Manager",
                    HireDate = new DateTime(2024, 5, 3),
                    TerminationDate = null,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = new DateTime(2024, 5, 3),
                    UpdatedDate = new DateTime(2024, 5, 3)
                },
                new User
                {
                    ID = 9,
                    FirstName = "Janette",
                    LastName = "James",
                    MiddleNameOrInitial = "W",
                    Username = "Janette.James",
                    Password = Encryptor.HashPasswordV2("TimeForSteak77"),
                    EmailAddress = "Janette.James@Cerebus.fake",
                    PhoneNumber = "908-555-4192",
                    StreetAddress = "1198 Hedge Street",
                    City = "Millington",
                    State = ((int)USStates.NJ).ToString(),
                    ZipCode = "07946",
                    Title = "Customer Service Representative",
                    HireDate = new DateTime(2025, 1, 9),
                    TerminationDate = null,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = new DateTime(2025, 1, 9),
                    UpdatedDate = new DateTime(2025, 1, 9)
                },
                new User
                {
                    ID = 10,
                    FirstName = "Van",
                    LastName = "Harmon",
                    MiddleNameOrInitial = "T",
                    Username = "Van.Harmon",
                    Password = Encryptor.HashPasswordV2("MyPassword123"),
                    EmailAddress = "Van.Harmon@Cerebus.fake",
                    PhoneNumber = "315-555-7346",
                    StreetAddress = "1698 Saint Marys Avenue",
                    City = "Syracuse",
                    State = ((int)USStates.NY).ToString(),
                    ZipCode = "13221",
                    Title = "Customer Service Representative",
                    HireDate = new DateTime(2025, 2, 18),
                    TerminationDate = null,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = new DateTime(2025, 2, 18),
                    UpdatedDate = new DateTime(2025, 2, 18)
                }
            );
        }
        catch (Exception ex)
        {

        }
    }

    private static void SeedStates(ModelBuilder modelBuilder)
    {
        try
        {

        }
        catch (Exception ex)
        {

        }
    }
}
