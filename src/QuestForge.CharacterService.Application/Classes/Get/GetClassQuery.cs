using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Classes.Get;

public class GetClassQuery : Query
{
    public Guid Id { get; set; }
}