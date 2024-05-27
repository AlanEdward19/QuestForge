using QuestForge.CharacterService.Core.Characters.Enums;

namespace QuestForge.CharacterService.Core.Commons.DataModels;

public class RaceDataModel
{
    [Key]
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public Dictionary<EAbilityScore, int> AbilityScoreIncrease{ get; private set; }

    public RaceDataModel() { }

    public RaceDataModel(Guid id, string name, string description, Dictionary<EAbilityScore, int> abilityScoreIncrease)
    {
        Id = id;
        Name = name;
        Description = description;
        AbilityScoreIncrease = abilityScoreIncrease;
    }
}