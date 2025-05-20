using System;

namespace dotnet_webapi.Dtos.Weapon;

public class AddWeaponDto
{
    public string Name { get; set; } = string.Empty;

    public int Damage { get; set; }

    public int CharacterId { get; set; }
}
