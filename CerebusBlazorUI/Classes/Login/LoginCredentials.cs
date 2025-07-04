using System;
using System.ComponentModel.DataAnnotations;
using CerebusBlazorUI.Interfaces.Login;

namespace CerebusBlazorUI.Classes.Login;

/// <summary>
/// Object storing login credentials, password in plain text.  
/// </summary>
public class LoginCredentials : ILoginCredentials

{
    public string? Username { get; set; }
    public string? Password { get; set; }

    public LoginCredentials()
    {
        Username = string.Empty;
        Password = string.Empty;
    }
}
