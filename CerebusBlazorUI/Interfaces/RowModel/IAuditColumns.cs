using System;

namespace CerebusBlazorUI.Interfaces.RowModel;

/// <summary>
/// Adds the audit columns CreatedBy, CreatedDate, UpdatedBy, and UpdatedDate
/// </summary>
public interface IAuditColumns
{
    string CreatedBy { get; set; }
    DateTime CreatedDate { get; set; }
    string UpdatedBy { get; set; }
    DateTime UpdatedDate { get; set; }

}
