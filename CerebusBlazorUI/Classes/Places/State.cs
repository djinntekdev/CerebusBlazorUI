using System;
using System.ComponentModel.DataAnnotations;
using CerebusBlazorUI.Classes.RowModel;

namespace CerebusBlazorUI.Classes.Places;

/// <summary>
/// List of US States
/// </summary>
public class USState : RowBase
{
    #region Constructors 

    public USState(string name, string abbrev)
    {
        Name = name;
        Abbreviation = abbrev;
    }

    public USState()
    {
        Name = string.Empty;
        Abbreviation = string.Empty;
    }

    #endregion 

    public string Name { get; set; }
    public string Abbreviation { get; set; }
}

public enum USStatesEnum
{
    AL = 1,
    AK,
    AZ,
    AR,
    CA,
    CO,
    CT,
    DE,
    FL,
    GA,
    HI,
    ID,
    IL,
    IN,
    IA,
    KS,
    KY,
    LA,
    ME,
    MD,
    MA,
    MI,
    MN,
    MS,
    MO,
    MT,
    NE,
    NV,
    NH,
    NJ,
    NM,
    NY,
    NC,
    ND,
    OH,
    OK,
    OR,
    PA,
    RI,
    SC,
    SD,
    TN,
    TX,
    UT,
    VT,
    VA,
    WA,
    WV,
    WI,
    WY,
    DC,
    PR
}
