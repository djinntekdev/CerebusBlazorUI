using System;
using System.ComponentModel.DataAnnotations;
using CerebusBlazorUI.Classes.Places;

namespace CerebusBlazorUI.Classes.User;

public class User
{

    #region Fields

    [Required]
    [Key]
    public int ID { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string FirstName { get; set; }
    public string MiddleNameOrInitial { get; set; }
    [Required]
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string PhoneNumber { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public USState State { get; set; }
    public string ZipCode { get; set; }
    public string Title { get; set; }
    public UserRole Role { get; set; }
    public DateTime HireDate { get; set; }

    public User Manager { get; set; }
    public int ManagerID { get; set; }
    public bool isManager { get; set; }
    public DateTime TerminationDate { get; set; }
    public bool isActive { get; set; }
    public bool isDeleted { get; set; }

    

    #endregion


}
