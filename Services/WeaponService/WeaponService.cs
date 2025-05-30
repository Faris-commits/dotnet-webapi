using System;
using System.Security.Claims;
using AutoMapper;
using dotnet_webapi.Data;
using dotnet_webapi.Dtos.Weapon;
using dotnet_webapi.Models;

namespace dotnet_webapi.Services.WeaponService;

public class WeaponService : IWeaponService
{
    private readonly DataContext _context;

    private readonly IHttpContextAccessor _httpContextAccessor;

    private readonly IMapper _mapper;

    public WeaponService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
    {
        _httpContextAccessor = httpContextAccessor;
        _mapper = mapper;
        _context = context;
    }
    public async Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon)
    {
        var response = new ServiceResponse<GetCharacterDto>();
        try
        {
            var character = await _context.Characters
             .FirstOrDefaultAsync(c => c.Id == newWeapon.CharacterId &&
             c.User!.Id == int.Parse(_httpContextAccessor.HttpContext!.User
             .FindFirstValue(ClaimTypes.NameIdentifier)!));
            if (character is null)
            {
                response.Success = false;
                response.Message = "Character not found";
                return response;
            }

            var weapon = new Weapon
            {
                Name = newWeapon.Name,
                Damage = newWeapon.Damage,
                Character = character
            };
            _context.Weapons.Add(weapon);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {

            response.Success = false;
            response.Message = ex.Message;
        }
        return response;
    }
}
