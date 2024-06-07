using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Items.Enums;

namespace QuestForge.CharacterService.Application.Items.Shop;

public class GenerateShopQuery(List<EItemType>? type, int size = 10) : Query
{
    public List<EItemType>? Type { get; private set; } = type;
    public int Size { get;  private set; } = size;
}