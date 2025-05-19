using System;

namespace dotnet_webapi.Dtos.User;

public class UserRegisterDto
{
    public string Username { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
}
