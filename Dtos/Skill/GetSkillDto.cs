using System;

namespace dotnet_webapi.Dtos.Skill;

public class GetSkillDto
{
    public string Name { get; set; } = string.Empty;
    public int Damage { get; set; }
}
