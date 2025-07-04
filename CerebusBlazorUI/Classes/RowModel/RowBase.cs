using System;
using System.ComponentModel.DataAnnotations;
using CerebusBlazorUI.Interfaces.RowModel;

namespace CerebusBlazorUI.Classes.RowModel;

/// <summary>
/// Row model base class for adding required columns.  
/// </summary> 
public class RowBase : IIdentityKey, IAuditColumns, IIsActive, IIsDeleted
{
    [Key]
    [Required]
    public int ID { get; set; }
    [Required]
    public string CreatedBy { get; set; }
    [Required]
    public DateTime CreatedDate { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
}
