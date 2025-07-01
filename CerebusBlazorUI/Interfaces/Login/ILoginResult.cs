using System;

namespace CerebusBlazorUI.Interfaces.Login;

public interface ILoginResult
{
    string? UserName { get; set; }
    int StatusCode { get; set; }
    bool Success { get; set; }
    DateTime Time { get; set; }
    bool BadUserName { get; set; }
    bool BadPassWord { get; set; }
    bool ErrorOccurred { get; set; }
    string? Message { get; set; }
}
