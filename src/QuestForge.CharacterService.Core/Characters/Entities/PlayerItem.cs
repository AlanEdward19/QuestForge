using QuestForge.CharacterService.Core.Commons.Entities;

namespace QuestForge.CharacterService.Core.Characters.Entities;

public class PlayerItem(Guid id, Item item, int quantity, bool isEquipped)
{
    public Guid Id { get; private set; } = id;
    public Item Item { get; private set; } = item;
    public int Quantity { get; private set; } = quantity;
    public bool IsEquipped { get; private set; } = isEquipped;
}