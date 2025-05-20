using System;
using AutoMapper;
using dotnet_webapi.Dtos.Skill;
using dotnet_webapi.Dtos.Weapon;
using dotnet_webapi.Models;

namespace dotnet_webapi;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Character, GetCharacterDto>();
        CreateMap<AddCharacterDto, Character>();
        CreateMap<Weapon, GetWeaponDto>();
        CreateMap<Skill, GetSkillDto>();
    }
}
