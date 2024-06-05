using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Entities;

namespace QuestForge.CharacterService.Core.Characters.Entities;

public class Backpack(Guid id, Guid characterId, List<PlayerItem>? items = null)
{
    [JsonIgnore]
    public Guid Id { get; private set; } = id;
    [JsonIgnore]
    public Guid CharacterId { get; private set; } = characterId;
    public List<PlayerItem> Items { get; private set; } = items ?? new List<PlayerItem>();

    public void AddItem(Item item, int quantity)
    {
        PlayerItem playerItem = new(Guid.NewGuid(), item, quantity, false);
        Items.Add(playerItem);
    }
    
    public void RemoveItem(Guid itemId)
    {
        PlayerItem? item = Items.FirstOrDefault(i => i.Id == itemId);
        if (item != null)
        {
            Items.Remove(item);
        }
    }

    public BackpackDataModel BuildClassDataModel()
    {
        return new(Id, CharacterId);
    }
}