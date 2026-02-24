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
    [Required(ErrorMessage = "First Name is required")]
    [StringLength(20)]
    public string FirstName { get; set; }
    public string MiddleNameOrInitial { get; set; }
    [Required(ErrorMessage = "Last Name is required")]
    [StringLength(20)]
    public string LastName { get; set; }
    [StringLength(150)]
    [Required(ErrorMessage = "Email Address is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string EmailAddress { get; set; }
    [Required(ErrorMessage = "Phone Number is required")]
    [StringLength(20)]
    [Phone(ErrorMessage = "Invalid Phone Number")]
    public string PhoneNumber { get; set; }
    [Required(ErrorMessage = "Street Address is required")]
    [StringLength(100)]
    public string StreetAddress { get; set; }
    [Required(ErrorMessage = "City is required")]
    [StringLength(50)]
    public string City { get; set; }
    [Required(ErrorMessage = "State is required")]
    [StringLength(25)]
    public string State { get; set; }
    [Required(ErrorMessage = "Zip Code is required")]
    [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip Code")]
    [StringLength(10)]
    public string ZipCode { get; set; }
    [StringLength(100)]
    public string Title { get; set; }
    //public UserRole Role { get; set; }
    [Required(ErrorMessage = "Hire Date is required")]
    public DateTime HireDate { get; set; }

    //public User Manager { get; set; }
    //public int ManagerID { get; set; }
    //public bool isManager { get; set; }
    public DateTime? TerminationDate { get; set; }
    //public int USStateID { get; set; }
    //public USState USState { get; set; } = null!;


    #endregion

}

public class UserModel
{
    [Required(ErrorMessage = "First Name is required")]
    [StringLength(20)]
    public string? FirstName { get; set; }
    public string? MiddleNameOrInitial { get; set; }
    [Required(ErrorMessage = "Last Name is required")]
    [StringLength(20)]
    public string? LastName { get; set; }
    [StringLength(150)]
    [Required(ErrorMessage = "Email Address is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string? EmailAddress { get; set; }
    [Required(ErrorMessage = "Phone Number is required")]
    [StringLength(20)]
    [Phone(ErrorMessage = "Invalid Phone Number")]
    public string? PhoneNumber { get; set; }
    [Required(ErrorMessage = "Street Address is required")]
    [StringLength(100)]
    public string? StreetAddress { get; set; }
    [Required(ErrorMessage = "City is required")]
    [StringLength(50)]
    public string? City { get; set; }
    //[Required(ErrorMessage = "State is required")]
    //[StringLength(25)]
    public string? State { get; set; }
    [Required(ErrorMessage = "Zip Code is required")]
    [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip Code")]
    [StringLength(10)]
    public string? ZipCode { get; set; }
    public string? Title { get; set; }
    [Required(ErrorMessage = "Hire Date is required")]
    public DateTime HireDate { get; set; }
}

public class UserSearchModel
{
    public string? FirstName { get; set; }
    public string? MiddleNameOrInitial { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? PhoneNumber { get; set; }
    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public string? Title { get; set; }
    public DateTime HireDate { get; set; }
}