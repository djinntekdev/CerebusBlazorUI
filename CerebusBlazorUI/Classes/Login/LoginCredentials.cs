using System;
using System.ComponentModel.DataAnnotations;
using CerebusBlazorUI.Interfaces.Login;

namespace CerebusBlazorUI.Classes.Login;

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
