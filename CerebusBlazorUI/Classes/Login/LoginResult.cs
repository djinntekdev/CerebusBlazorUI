using System;
using CerebusBlazorUI.Interfaces.Login;

namespace CerebusBlazorUI.Classes.Login;

public class LoginResult : ILoginResult
{
    public string? UserName { get; set; }
    public int StatusCode { get; set; }
    public bool Success { get; set; }
    public DateTime Time { get; set; }
    public bool BadUserName { get; set; }
    public bool BadPassWord { get; set; }
    public bool ErrorOccurred { get; set; }
    public string? Message { get; set; }
}
