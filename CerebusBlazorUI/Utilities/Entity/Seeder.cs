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
        SeedStates(modelBuilder);
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
                    State = ((int)USStatesEnum.NY).ToString(),
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
                    State = ((int)USStatesEnum.NY).ToString(),
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
                    State = ((int)USStatesEnum.MA).ToString(),
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
                    State = ((int)USStatesEnum.NY).ToString(),
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
                    State = ((int)USStatesEnum.CT).ToString(),
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
                    State = ((int)USStatesEnum.NY).ToString(),
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
                    State = ((int)USStatesEnum.ME).ToString(),
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
                    State = ((int)USStatesEnum.PA).ToString(),
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
                    State = ((int)USStatesEnum.NJ).ToString(),
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
                    State = ((int)USStatesEnum.NY).ToString(),
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
            modelBuilder.Entity<USState>().HasData(
                new USState
                {
                    ID = 1,
                    Name = "Alabama",
                    Abbreviation = USStatesEnum.AL.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 2,
                    Name = "Alaska",
                    Abbreviation = USStatesEnum.AK.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 3,
                    Name = "Arizona",
                    Abbreviation = USStatesEnum.AZ.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 4,
                    Name = "Arkansas",
                    Abbreviation = USStatesEnum.AR.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 5,
                    Name = "California",
                    Abbreviation = USStatesEnum.CA.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 6,
                    Name = "Colorado",
                    Abbreviation = USStatesEnum.CO.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 7,
                    Name = "Connecticut",
                    Abbreviation = USStatesEnum.CT.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 8,
                    Name = "Delaware",
                    Abbreviation = USStatesEnum.DE.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 9,
                    Name = "Florida",
                    Abbreviation = USStatesEnum.FL.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 10,
                    Name = "Georgia",
                    Abbreviation = USStatesEnum.GA.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 11,
                    Name = "Hawaii",
                    Abbreviation = USStatesEnum.HI.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 12,
                    Name = "Idaho",
                    Abbreviation = USStatesEnum.ID.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 13,
                    Name = "Illinois",
                    Abbreviation = USStatesEnum.IL.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 14,
                    Name = "Indiana",
                    Abbreviation = USStatesEnum.IN.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 15,
                    Name = "Iowa",
                    Abbreviation = USStatesEnum.IA.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 16,
                    Name = "Kansas",
                    Abbreviation = USStatesEnum.KS.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 17,
                    Name = "Kentucky",
                    Abbreviation = USStatesEnum.KY.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 18,
                    Name = "Louisiana",
                    Abbreviation = USStatesEnum.LA.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 19,
                    Name = "Maine",
                    Abbreviation = USStatesEnum.ME.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 20,
                    Name = "Maryland",
                    Abbreviation = USStatesEnum.MD.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 21,
                    Name = "Massachusetts",
                    Abbreviation = USStatesEnum.MA.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 22,
                    Name = "Michigan",
                    Abbreviation = USStatesEnum.MI.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 23,
                    Name = "Minnesota",
                    Abbreviation = USStatesEnum.MN.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 24,
                    Name = "Mississippi",
                    Abbreviation = USStatesEnum.MS.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 25,
                    Name = "Missouri",
                    Abbreviation = USStatesEnum.MO.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 26,
                    Name = "Montana",
                    Abbreviation = USStatesEnum.MT.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 27,
                    Name = "Nebraska",
                    Abbreviation = USStatesEnum.NE.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 28,
                    Name = "Nevada",
                    Abbreviation = USStatesEnum.NV.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 29,
                    Name = "New Hampshire",
                    Abbreviation = USStatesEnum.NH.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 30,
                    Name = "New Jersey",
                    Abbreviation = USStatesEnum.NJ.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 31,
                    Name = "New Mexico",
                    Abbreviation = USStatesEnum.NM.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 32,
                    Name = "New York",
                    Abbreviation = USStatesEnum.NY.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 33,
                    Name = "North Carolona",
                    Abbreviation = USStatesEnum.NC.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 34,
                    Name = "North Dakota",
                    Abbreviation = USStatesEnum.ND.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 35,
                    Name = "Ohio",
                    Abbreviation = USStatesEnum.OH.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 36,
                    Name = "Oklahoma",
                    Abbreviation = USStatesEnum.OK.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 37,
                    Name = "Oregon",
                    Abbreviation = USStatesEnum.OR.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 38,
                    Name = "Pennsylvania",
                    Abbreviation = USStatesEnum.PA.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 39,
                    Name = "Rhode Island",
                    Abbreviation = USStatesEnum.RI.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 40,
                    Name = "South Carolina",
                    Abbreviation = USStatesEnum.SC.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 41,
                    Name = "South Dakota",
                    Abbreviation = USStatesEnum.SD.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 42,
                    Name = "Tennessee",
                    Abbreviation = USStatesEnum.TN.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 43,
                    Name = "Texas",
                    Abbreviation = USStatesEnum.TX.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 44,
                    Name = "Utah",
                    Abbreviation = USStatesEnum.UT.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 45,
                    Name = "Vermont",
                    Abbreviation = USStatesEnum.VT.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 46,
                    Name = "Virginia",
                    Abbreviation = USStatesEnum.VA.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 47,
                    Name = "Washington",
                    Abbreviation = USStatesEnum.WA.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 48,
                    Name = "West Virginia",
                    Abbreviation = USStatesEnum.WV.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 49,
                    Name = "Wisconsin",
                    Abbreviation = USStatesEnum.WI.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 50,
                    Name = "Wyoming",
                    Abbreviation = USStatesEnum.WY.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 51,
                    Name = "District of Columbia",
                    Abbreviation = USStatesEnum.DC.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                },
                new USState
                {
                    ID = 52,
                    Name = "Puerto Rico",
                    Abbreviation = USStatesEnum.PR.ToString(),
                    CreatedBy = "admin",
                    UpdatedBy = "admin",
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                }
            );
        }
        catch (Exception ex)
        {

        }
    }
}
