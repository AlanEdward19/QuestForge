using QuestForge.CharacterService.Core.Backgrounds.Aggregates;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Core.Backgrounds.DataModels;

public class BackgroundDataModel : BaseDataModel
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public List<ESkillProficiency> Proficiencies { get; private set; }
    public int InitialWealth { get; private set; }
    //falta idiomas
    public virtual List<ItemDataModel> Items { get; private set; }
    public virtual List<TraitDataModel> Traits { get; private set; }
    public virtual List<CharacterDataModel> Characters { get; private set; }

    public BackgroundDataModel() { }

    public BackgroundDataModel(string name, string description, List<ESkillProficiency> proficiencies, int initialWealth, List<ItemDataModel> items,
        List<TraitDataModel> traits) : base(new Guid())
    {
        Name = name;
        Description = description;
        Proficiencies = proficiencies;
        InitialWealth = initialWealth;
        Items = items;
        Traits = traits;
    }

    public BackgroundDataModel(string name, string description, List<ESkillProficiency> proficiencies, int initialWealth, List<ItemDataModel> items) : base(new Guid())
    {
        Name = name;
        Description = description;
        Proficiencies = proficiencies;
        InitialWealth = initialWealth;
        Items = items;
    }

    public BackgroundDataModel(string name, string description, List<ESkillProficiency> proficiencies, int initialWealth, List<TraitDataModel> traits) : base(new Guid())
    {
        Name = name;
        Description = description;
        Proficiencies = proficiencies;
        InitialWealth = initialWealth;
        Traits = traits;
    }

    public override void UpdateBasedOnValueObject(ValueObject valueObject)
    {
        var parsedValueObject = valueObject as BackgroundAggregateRoot;

        Name = parsedValueObject!.Name;
        Description = parsedValueObject.Description;
        Proficiencies = parsedValueObject.Proficiencies;
        InitialWealth = parsedValueObject.InitialWealth;
        Items = parsedValueObject.Items
            .Select(x => new ItemDataModel(x.Id, x.Name, x.Description, x.Type, x.Value, x.CurrencyType, x.Weight))
            .ToList();
        Traits = parsedValueObject.Traits
            .Select(x => new TraitDataModel(x.Id, Id, x.Type, x.Description))
            .ToList();

        base.UpdateBasedOnValueObject(valueObject);
    }
}