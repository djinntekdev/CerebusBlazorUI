using System;
using System.ComponentModel.DataAnnotations;
using CerebusBlazorUI.Classes.RowModel;

namespace CerebusBlazorUI.Classes.User;

/// <summary>
/// Class storing user role info and permissions
/// </summary>
public class UserRole : RowBase
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    public bool IsAdmin { get; set; }
}
