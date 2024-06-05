using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Backgrounds.Get;

public class GetBackgroundQuery : Query
{
    public Guid Id { get; set; }
}