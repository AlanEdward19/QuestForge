using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Characters.Get;

public class GetCharacterQuery : Query
{
    public Guid Id { get; set; }
}