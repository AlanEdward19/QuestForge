using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Core.Common.ValueObjects;

public class AbilityScoreValueObject : BaseDataModel
{
    public EAbility AbilityScore { get; private set; }

    public int Value { get; private set; }

    public AbilityScoreValueObject() { }

    public AbilityScoreValueObject(EAbility abilityScore, int value) : base(Guid.NewGuid())
    {
        AbilityScore = abilityScore;
        Value = value;
    }

    public static List<AbilityScoreValueObject> BuildFromDictionary(Dictionary<EAbility, int> abilityScoreIncrease)
    {
        var abilityScoreValueObjects = new List<AbilityScoreValueObject>();

        foreach (var (abilityScore, value) in abilityScoreIncrease)
        {
            if (value != 0)
                abilityScoreValueObjects.Add(new AbilityScoreValueObject(abilityScore, value));
        }

        return abilityScoreValueObjects;
    }

    public static Dictionary<EAbility, int> BuildFromValueObjects(
        List<AbilityScoreValueObject> abilityScoreValueObjects)
    {
        var abilityScoreIncrease = new Dictionary<EAbility, int>();

        foreach (var abilityScoreValueObject in abilityScoreValueObjects)
        {
            abilityScoreIncrease.Add(abilityScoreValueObject.AbilityScore, abilityScoreValueObject.Value);
        }

        return abilityScoreIncrease;
    }
}