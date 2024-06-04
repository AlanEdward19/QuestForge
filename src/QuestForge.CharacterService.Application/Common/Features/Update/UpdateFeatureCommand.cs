using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Common.Features.Update;

public class UpdateFeatureCommand(string? name, string? description) : Command
{
    public Guid Id { get; private set; }
    public string? Name { get; private set; } = name;
    public string? Description { get; private set; } = description;

    public void SetId(Guid id) => Id = id;
}