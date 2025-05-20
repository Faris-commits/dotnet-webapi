using System;
using dotnet_webapi.Dtos.Fight;

namespace dotnet_webapi.Services.FightService;

public interface IFightService
{
    Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);

    Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);

    Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);

    Task<ServiceResponse<List<HighScoreDto>>> GetHighscore();
}
