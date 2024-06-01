using QuestForge.CharacterService.Core.Classes.Entities;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;

namespace QuestForge.CharacterService.Core.Common.DataModels;

public class ClassDataModel : BaseDataModel
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int HitDie { get; private set; }

    public ClassDataModel() { }

    public ClassDataModel(string name, string description, int hitDie) : base(Guid.NewGuid())
    {
        Name = name;
        Description = description;
        HitDie = hitDie;
    }

    public override void UpdateBasedOnValueObject(ValueObject valueObject)
    {
        var parsedValueObject = valueObject as Class;
        
        Name = parsedValueObject!.Name;
        Description = parsedValueObject.Description;
        HitDie = parsedValueObject.HitDie;
        
        base.UpdateBasedOnValueObject(valueObject);
    }
}