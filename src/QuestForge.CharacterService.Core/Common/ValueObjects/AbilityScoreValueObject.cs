using QuestForge.CharacterService.Core.Characters.Enums;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Core.Common.ValueObjects;

public class AbilityScoreValueObject : BaseDataModel
{
    public EAbilityScore AbilityScore { get; private set; }

    public int Value { get; private set; }

    public AbilityScoreValueObject() { }

    public AbilityScoreValueObject(EAbilityScore abilityScore, int value) : base(Guid.NewGuid())
    {
        AbilityScore = abilityScore;
        Value = value;
    }

    public static List<AbilityScoreValueObject> BuildFromDictionary(Dictionary<EAbilityScore, int> abilityScoreIncrease)
    {
        var abilityScoreValueObjects = new List<AbilityScoreValueObject>();

        foreach (var (abilityScore, value) in abilityScoreIncrease)
        {
            if (value != 0)
                abilityScoreValueObjects.Add(new AbilityScoreValueObject(abilityScore, value));
        }

        return abilityScoreValueObjects;
    }

    public static Dictionary<EAbilityScore, int> BuildFromValueObjects(
        List<AbilityScoreValueObject> abilityScoreValueObjects)
    {
        var abilityScoreIncrease = new Dictionary<EAbilityScore, int>();

        foreach (var abilityScoreValueObject in abilityScoreValueObjects)
        {
            abilityScoreIncrease.Add(abilityScoreValueObject.AbilityScore, abilityScoreValueObject.Value);
        }

        return abilityScoreIncrease;
    }
}