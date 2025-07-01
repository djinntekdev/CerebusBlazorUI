using System;
using CerebusBlazorUI.Classes.Login;

namespace CerebusBlazorUI.Interfaces.Login;

public interface ILoginCredentials
{
    string? Username { get; set; }
    string? Password { get; set; }

}
