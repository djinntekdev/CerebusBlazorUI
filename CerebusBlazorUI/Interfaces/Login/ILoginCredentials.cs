using System;
using CerebusBlazorUI.Classes.Login;

namespace CerebusBlazorUI.Interfaces.Login;

/// <summary>
/// Interface for login credentials
/// </summary>
public interface ILoginCredentials
{
    string? Username { get; set; }
    string? Password { get; set; }

}
