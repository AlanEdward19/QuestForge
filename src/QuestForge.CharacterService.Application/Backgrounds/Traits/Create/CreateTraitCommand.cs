using QuestForge.CharacterService.Core.Backgrounds.Enums;
using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Backgrounds.Traits.Create;

public class CreateTraitCommand(Guid backgroundId, ETraitType type, string description) : Command
{
    public Guid BackgroundId { get; private set; } = backgroundId;
    public ETraitType Type { get; private set; } = type;
    public string Description { get; private set; } = description;
}