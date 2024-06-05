using QuestForge.CharacterService.Core.Backgrounds.Enums;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;

namespace QuestForge.CharacterService.Core.Backgrounds.DataModels;

public class TraitDataModel : BaseDataModel
{
    public Guid BackgroundId { get; private set; }
    public ETraitType Type { get; private set; }
    public string Description { get; private set; }

    [ForeignKey(nameof(BackgroundId))]
    public virtual BackgroundDataModel Background { get; private set; }

    public TraitDataModel() { }

    public TraitDataModel(Guid backgroundId, ETraitType type, string description) : base(Guid.NewGuid())
    {
        BackgroundId = backgroundId;
        Type = type;
        Description = description;
    }

    public TraitDataModel(Guid id, Guid backgroundId, ETraitType type, string description) : base(id)
    {
        BackgroundId = backgroundId;
        Type = type;
        Description = description;
    }
}