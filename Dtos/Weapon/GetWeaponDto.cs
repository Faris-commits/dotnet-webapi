using System;

namespace dotnet_webapi.Dtos.Weapon;

public class GetWeaponDto
{
    public string Name { get; set; } = string.Empty;

    public int Damage { get; set; }
}
