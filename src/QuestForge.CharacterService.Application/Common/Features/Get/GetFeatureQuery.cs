using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Common.Features.Get;

public class GetFeatureQuery : Query
{
    public Guid Id { get; set; }
}