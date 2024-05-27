using QuestForge.CharacterService.Core.Commons.Entities;

namespace QuestForge.CharacterService.Core.Characters.Entities;

public class Backpack(Guid id, List<PlayerItem>? items = null)
{
    public Guid Id { get; private set; } = id;
    public List<PlayerItem> Items { get; private set; } = items ?? new List<PlayerItem>();

    public void AddItem(Item item, int quantity)
    {
        PlayerItem playerItem = new(Guid.NewGuid(), item, quantity, false);
        Items.Add(playerItem);
    }
}