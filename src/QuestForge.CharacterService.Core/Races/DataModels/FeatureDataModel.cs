using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.Entities;

namespace QuestForge.CharacterService.Core.Races.DataModels;

public class FeatureDataModel : BaseDataModel
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public virtual List<RaceDataModel> Races { get; private set; }

    public FeatureDataModel() : base() { }

    public FeatureDataModel(string name, string description) : base(Guid.NewGuid())
    {
        Name = name;
        Description = description;
    }

    public FeatureDataModel(Guid id, string name, string description) : base(id)
    {
        Name = name;
        Description = description;
    }

    public override void UpdateBasedOnValueObject(ValueObject valueObject)
    {
        var parsedValueObject = valueObject as Feature;

        Name = parsedValueObject!.Name;
        Description = parsedValueObject.Description;

        base.UpdateBasedOnValueObject(valueObject);
    }
}