using System;

namespace dotnet_webapi.Dtos.Character;

public class AddCharacterSkillDto
{
    public int CharacterId { get; set; }
    public int SkillId { get; set; }
    
}
