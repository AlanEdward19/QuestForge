using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Common.Features.Create;

public class CreateFeatureCommand(string? name, string? description) : Command
{
    public string? Name { get; private set; } = name;
    public string? Description { get; private set; } = description;
}