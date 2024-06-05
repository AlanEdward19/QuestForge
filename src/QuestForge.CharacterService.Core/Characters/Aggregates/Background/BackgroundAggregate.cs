using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Utils.Converters;
using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Items.Entities;

namespace QuestForge.CharacterService.Core.Characters.Aggregates.Background;

public class BackgroundAggregate : ValueObject
{
    [JsonIgnore]
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    [JsonConverter(typeof(EnumListToStringListConverter<ESkillProficiency>))]
    public List<ESkillProficiency> Proficiencies { get; private set; }
    public List<Item> Items { get; private set; }
    public List<Trait> Traits { get; private set; }

    public BackgroundAggregate(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as BackgroundDataModel;

        Id = parsedDataModel!.Id;
        Name = parsedDataModel!.Name;
        Description = parsedDataModel.Description;
        Proficiencies = parsedDataModel.Proficiencies;
        Items = parsedDataModel.Items
            .Select(x => new Item(x))
            .ToList();
        Traits = parsedDataModel.Traits
            .Select(x => new Trait(x))
            .ToList();
    }
}