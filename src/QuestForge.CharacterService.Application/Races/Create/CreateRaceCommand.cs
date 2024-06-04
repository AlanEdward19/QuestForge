using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Application.Races.Create;

public class CreateRaceCommand(string? name, string? description, Dictionary<EAbility, int>? abilityScoreIncrease, double? movement, IEnumerable<Guid> featureIds) : Command
{
    public string? Name { get; private set; } = name;
    public string? Description { get; private set; } = description;
    public Dictionary<EAbility, int>? AbilityScoreIncrease { get; private set; } = abilityScoreIncrease;
    public double? Movement { get; private set; } = movement;
    public IEnumerable<Guid> FeatureIds { get; private set; } = featureIds;
}