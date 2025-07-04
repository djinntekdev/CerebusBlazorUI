using System;
using System.ComponentModel.DataAnnotations;
using CerebusBlazorUI.Classes.Places;
using CerebusBlazorUI.Classes.RowModel;

namespace CerebusBlazorUI.Classes.User;

/// <summary>
/// User data for the application
/// </summary>
public class User : RowBase
{

    #region Fields

    [Required]
    [StringLength(25)]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    [StringLength(20)]
    public string FirstName { get; set; }
    public string MiddleNameOrInitial { get; set; }
    [Required]
    [StringLength(20)]
    public string LastName { get; set; }
    [StringLength(150)]
    [Required]
    public string EmailAddress { get; set; }
    [StringLength(20)]
    public string PhoneNumber { get; set; }
    [StringLength(100)]
    public string StreetAddress { get; set; }
    [StringLength(50)]
    public string City { get; set; }
    [StringLength(25)]
    public string State { get; set; }
    [StringLength(10)]
    public string ZipCode { get; set; }
    [StringLength(100)]
    public string Title { get; set; }
    //public UserRole Role { get; set; }
    public DateTime HireDate { get; set; }

    //public User Manager { get; set; }
    //public int ManagerID { get; set; }
    //public bool isManager { get; set; }
    public DateTime TerminationDate { get; set; }


    #endregion


}
