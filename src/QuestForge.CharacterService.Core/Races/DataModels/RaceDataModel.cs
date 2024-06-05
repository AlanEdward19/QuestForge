using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.ValueObjects;
using QuestForge.CharacterService.Core.Races.Entities;

namespace QuestForge.CharacterService.Core.Races.DataModels;

public class RaceDataModel : BaseDataModel
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public double Movement { get; private set; }
    public virtual List<RaceAbilityScoreDataModel> AbilityScoreIncrease { get; private set; }
    public virtual List<FeatureDataModel> Features { get; private set; }

    public RaceDataModel() { }

    public RaceDataModel(Guid id, string name, string description, double movement,
        List<AbilityScoreValueObject> abilityScoreIncrease, List<FeatureDataModel> features) : base(id)
    {
        Name = name;
        Description = description;
        AbilityScoreIncrease = abilityScoreIncrease
            .Select(x => new RaceAbilityScoreDataModel(Id, x))
            .ToList();
        Movement = movement;
        Features = features;
    }

    public override void UpdateBasedOnValueObject(ValueObject valueObject)
    {
        var parsedValueObject = valueObject as Race;

        Name = parsedValueObject!.Name;
        Description = parsedValueObject.Description;
        AbilityScoreIncrease = AbilityScoreValueObject
                .BuildFromDictionary(parsedValueObject.AbilityScoreIncrease)
                .Select(x => new RaceAbilityScoreDataModel(Id, x))
                .ToList();
        Movement = parsedValueObject.Movement;

        base.UpdateBasedOnValueObject(valueObject);
    }
}