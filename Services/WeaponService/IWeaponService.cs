using System;
using dotnet_webapi.Dtos.Weapon;

namespace dotnet_webapi.Services.WeaponService;

public interface IWeaponService
{
    Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeaponDto);
}
