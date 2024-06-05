using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Backgrounds.Traits.Get;

public class GetTraitQuery : Query
{
    public Guid Id { get; set; }
}