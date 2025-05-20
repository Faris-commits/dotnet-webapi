using System;
using dotnet_webapi.Dtos.Weapon;
using dotnet_webapi.Services.WeaponService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_webapi.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class WeaponController : ControllerBase
{
    private readonly IWeaponService _weaponService;

    public WeaponController(IWeaponService weaponService)
    {
        _weaponService = weaponService;
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
    {
        return Ok(await _weaponService.AddWeapon(newWeapon));
    }

}
