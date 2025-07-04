using System;
using System.ComponentModel.DataAnnotations;

namespace CerebusBlazorUI.Interfaces.RowModel;

/// <summary>
/// Adds identity key
/// </summary>
public interface IIdentityKey
{
    int ID { get; set; }
}
