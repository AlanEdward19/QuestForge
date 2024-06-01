using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Races.Get;

public class GetRaceQuery : Query
{
    public Guid Id { get; set; }
}