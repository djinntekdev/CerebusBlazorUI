using System;
using System.ComponentModel.DataAnnotations;
using CerebusBlazorUI.Classes.RowModel;

namespace CerebusBlazorUI.Classes.Places;

/// <summary>
/// List of US States
/// </summary>
public class USState : RowBase
{
    [Required]
    public int Name { get; set; }
    [Required]
    public int Abbreviation { get; set; }
}
