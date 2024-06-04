using QuestForge.CharacterService.Core.Characters.Enums;
using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Races.Create;

public class CreateRaceCommand(string? name, string? description, Dictionary<EAbilityScore, int>? abilityScoreIncrease, double? movement) : Command
{
    public string? Name { get; private set; } = name;
    public string? Description { get; private set; } = description;
    public Dictionary<EAbilityScore, int>? AbilityScoreIncrease { get; private set; } = abilityScoreIncrease;
    public double? Movement { get; private set; } = movement;
}