using System;

namespace dotnet_webapi.Dtos.Fight;

public class FightRequestDto
{
    public List<int> CharacterIds { get; set; } = new List<int>();
}
