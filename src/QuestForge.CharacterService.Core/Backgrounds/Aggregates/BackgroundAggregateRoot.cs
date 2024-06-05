using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Utils.Converters;
using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Backgrounds.Entities;
using QuestForge.CharacterService.Core.Items.Entities;

namespace QuestForge.CharacterService.Core.Backgrounds.Aggregates;

public class BackgroundAggregateRoot : ValueObject
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    [JsonConverter(typeof(EnumListToStringListConverter<ESkillProficiency>))]
    public List<ESkillProficiency> Proficiencies { get; private set; }
    public int InitialWealth { get; private set; }
    public List<Item> Items { get; private set; }
    public List<Trait> Traits { get; private set; }

    public BackgroundAggregateRoot(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as BackgroundDataModel;

        Name = parsedDataModel!.Name;
        Description = parsedDataModel.Description;
        Proficiencies = parsedDataModel.Proficiencies;
        InitialWealth = parsedDataModel.InitialWealth;
        Items = parsedDataModel.Items
            .Select(x => new Item(x))
            .ToList();
        Traits = parsedDataModel.Traits
            .Select(x => new Trait(x))
            .ToList();
    }

    public void UpdateName(string? name)
    {
        if (!string.IsNullOrWhiteSpace(name) && !Name.Equals(name))
            Name = name;
    }

    public void UpdateDescription(string? description)
    {
        if (!string.IsNullOrWhiteSpace(description) && !Description.Equals(description))
            Description = description;
    }

    public void UpdateProficiencies(List<ESkillProficiency>? proficiencies)
    {
        if (proficiencies != null && !Proficiencies.SequenceEqual(proficiencies))
            Proficiencies = proficiencies;
    }

    public void UpdateItems(List<Item>? items)
    {
        if (items != null && !Items.SequenceEqual(items))
            Items = items;
    }

    public void UpdateTraits(List<Trait>? traits)
    {
        if (traits != null && !Traits.SequenceEqual(traits))
            Traits = traits;
    }

    public void UpdateInitialWealth(int? initialWealth)
    {
        if (initialWealth != null && !InitialWealth.Equals(initialWealth))
            InitialWealth = initialWealth.Value;
    }
}