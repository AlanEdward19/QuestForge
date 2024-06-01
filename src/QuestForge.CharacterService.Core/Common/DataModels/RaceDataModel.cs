using QuestForge.CharacterService.Core.Characters.Enums;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.ValueObjects;
using QuestForge.CharacterService.Core.Races.Entities;

namespace QuestForge.CharacterService.Core.Common.DataModels;

public class RaceDataModel : BaseDataModel
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public virtual List<RaceAbilityScoreDataModel> AbilityScoreIncrease { get; private set; }

    public RaceDataModel() { }

    public RaceDataModel(Guid id, string name, string description,
        List<AbilityScoreValueObject> abilityScoreIncrease) : base(id)
    {
        Name = name;
        Description = description;
        AbilityScoreIncrease = abilityScoreIncrease
            .Select(x => new RaceAbilityScoreDataModel(Id, x))
            .ToList();
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

        base.UpdateBasedOnValueObject(valueObject);
    }
}