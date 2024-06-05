using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Items.Entities;

namespace QuestForge.CharacterService.Core.Characters.Aggregates.Backpack;

public class PlayerItem(Guid id, Item item, int quantity, bool isEquipped)
{
    [JsonIgnore]
    public Guid Id { get; private set; } = id;
    public Item Item { get; private set; } = item;
    public int Quantity { get; private set; } = quantity;
    public bool IsEquipped { get; private set; } = isEquipped;
}