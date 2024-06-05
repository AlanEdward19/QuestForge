using QuestForge.CharacterService.Core.Backgrounds.Enums;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Utils.Converters;
using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;

namespace QuestForge.CharacterService.Core.Backgrounds.Entities;

public class Trait : ValueObject
{
    public Guid Id { get; private set; }
    public Guid BackgroundId { get; private set; }
    [JsonConverter(typeof(EnumToStringConverter<ETraitType>))]
    public ETraitType Type { get; private set; }
    public string Description { get; private set; }

    public Trait(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as TraitDataModel;

        Id = parsedDataModel!.Id;
        BackgroundId = parsedDataModel.BackgroundId;
        Type = parsedDataModel.Type;
        Description = parsedDataModel.Description;
    }

    public void UpdateBackgroundId(Guid? backgroundId)
    {
        if (backgroundId != null && !BackgroundId.Equals(backgroundId))
            BackgroundId = backgroundId.Value;
    }

    public void UpdateType(ETraitType? type)
    {
        if (type != null && !Type.Equals(type))
            Type = type.Value;
    }

    public void UpdateDescription(string? description)
    {
        if (!string.IsNullOrWhiteSpace(description) && !Description.Equals(description))
            Description = description;
    }
}