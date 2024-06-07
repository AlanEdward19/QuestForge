using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Characters.Items.TradeItem;

public class TradeItemCommand(Guid fromCharacterId, Guid toCharacterId, Guid itemId, int quantity) : Command
{
    public Guid FromCharacterId { get; private set; } = fromCharacterId;
    public Guid ToCharacterId { get; private set; } = toCharacterId;
    public Guid ItemId { get; private set; } = itemId;
    public int Quantity { get; private set; } = quantity;
}