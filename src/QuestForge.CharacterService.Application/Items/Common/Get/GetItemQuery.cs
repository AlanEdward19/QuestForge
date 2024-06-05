using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Items.Enums;

namespace QuestForge.CharacterService.Application.Items.Common.Get;

public class GetItemQuery : Query
{
    public Guid Id { get; set; }
    public EItemType Type { get; set; }
}