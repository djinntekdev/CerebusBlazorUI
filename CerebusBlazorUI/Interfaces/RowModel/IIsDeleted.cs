using System;

namespace CerebusBlazorUI.Interfaces.RowModel;

/// <summary>
/// Adds IsDeleted column
/// </summary>
public interface IIsDeleted
{
    bool IsDeleted { get; set; }
}
