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
    }

    private static void SeedUsers(ModelBuilder modelBuilder)
    {
        try
        {
            modelBuilder.Entity<User>().HasData(
                new User { ID = 1, FirstName = "Bob", LastName = "Reed", MiddleNameOrInitial = "L",
                    Username = "Bob.Reed", EmailAddress = "Bob.Reed@Cerebus.fake", PhoneNumber = "646-555-3047",
                    StreetAddress = "814 Geraldine Lane", City = "New York", State=((int)USStates.NY).ToString(), ZipCode = "10011" },
                new User { ID = 2, FirstName = "Latoya", LastName = "Carter", MiddleNameOrInitial = "N",
                    Username = "Latoya.Carter", EmailAddress = "Latoya.Carter@Cerebus.fake", PhoneNumber = "716-555-3630",
                    StreetAddress = "2034 Jarvis Street", City = "Buffalo", State=((int)USStates.NY).ToString(), ZipCode = "14222" },
                new User { ID = 3, FirstName = "Joshua", LastName = "Boyer",
                    Username = "Joshua.Boyer", EmailAddress = "Joshua.Boyer@Cerebus.fake", PhoneNumber = "508-555-2320",
                    StreetAddress = "3821 Randolph Street", City = "Cambridge", State=((int)USStates.MA).ToString(), ZipCode = "02141" },
                new User { ID = 4, FirstName = "Sandy", LastName = "William", MiddleNameOrInitial = "E",
                    Username = "Sandy.William", EmailAddress = "Sandy.William@Cerebus.fake", PhoneNumber = "212-555-3480",
                    StreetAddress = "35 Godfrey Road", City = "New York", State=((int)USStates.NY).ToString(), ZipCode = "10022" },
                new User { ID = 5, FirstName = "Christopher", LastName = "Cross", MiddleNameOrInitial = "U",
                    Username = "Christopher.Cross", EmailAddress = "Christopher.Cross@Cerebus.fake", PhoneNumber = "860-555-0200",
                    StreetAddress = "459 Hart Street", City = "459 Hart Street", State=((int)USStates.CT).ToString(), ZipCode = "06103" },
                new User { ID = 6, FirstName = "Trevor", LastName = "Ryan", MiddleNameOrInitial = "M" ,
                    Username = "Trevor.Ryan", EmailAddress = "Trevor.Ryan@Cerebus.fake", PhoneNumber = "518-555-2034",
                    StreetAddress = "3564 Hardesty Street", City = "Albany", State=((int)USStates.NY).ToString(), ZipCode = "12207" },
                new User { ID = 7, FirstName = "Arlene", LastName = "Dawson", MiddleNameOrInitial = "R",
                    Username = "Arlene.Dawson", EmailAddress = "Arlene.Dawson@Cerebus.fake", PhoneNumber = "207-555-2113",
                    StreetAddress = "262 Victoria Court", City = "Andover", State=((int)USStates.ME).ToString(), ZipCode = "04216" },
                new User { ID = 8, FirstName = "Anna", LastName = "Hartman" ,
                    Username = "Anna.Hartman", EmailAddress = "Anna.Hartman@Cerebus.fake", PhoneNumber = "814-555-1968",
                    StreetAddress = "2797 Coal Street", City = "Clarion", State=((int)USStates.PA).ToString(), ZipCode = "16214" },
                new User { ID = 9, FirstName = "Janette", LastName = "James", MiddleNameOrInitial = "W",
                    Username = "Janette.James", EmailAddress = "Janette.James@Cerebus.fake", PhoneNumber = "908-555-4192",
                    StreetAddress = "1198 Hedge Street", City = "Millington", State=((int)USStates.NJ).ToString(), ZipCode = "07946" },
                new User { ID = 10, FirstName = "Van", LastName = "Harmon", MiddleNameOrInitial = "T",
                    Username = "Van.Harmon", EmailAddress = "Van.Harmon@Cerebus.fake", PhoneNumber = "315-555-7346",
                    StreetAddress = "1698 Saint Marys Avenue", City = "Syracuse", State=((int)USStates.NY).ToString(), ZipCode = "13221" }            
            );
        }
        catch (Exception ex)
        {

        }
    }
}
