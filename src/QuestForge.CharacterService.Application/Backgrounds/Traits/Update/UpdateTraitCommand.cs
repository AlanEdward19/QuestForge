using QuestForge.CharacterService.Core.Backgrounds.Enums;
using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Backgrounds.Traits.Update;

public class UpdateTraitCommand(Guid? backgroundId, ETraitType? type, string? description) : Command
{
    public Guid Id { get; private set; }
    public Guid? BackgroundId { get; private set; } = backgroundId;
    public ETraitType? Type { get; private set; } = type;
    public string? Description { get; private set; } = description;

    public void SetId(Guid id) => Id = id;
}