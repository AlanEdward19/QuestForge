using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Backgrounds.Enums;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Utils.Converters;

namespace QuestForge.CharacterService.Core.Characters.Aggregates.Background;

public class Trait : ValueObject
{
    [JsonConverter(typeof(EnumToStringConverter<ETraitType>))]
    public ETraitType Type { get; private set; }
    public string Description { get; private set; }

    public Trait(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as TraitDataModel;

        Type = parsedDataModel.Type;
        Description = parsedDataModel.Description;
    }
}