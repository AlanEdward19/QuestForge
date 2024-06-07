using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Items.Entities;

namespace QuestForge.CharacterService.Core.Characters.Aggregates.Backpack;

public class BackpackAggregate : ValueObject
{
    [JsonIgnore] public Guid Id { get; private set; }
    [JsonIgnore] public Guid CharacterId { get; private set; }
    public List<CharacterItem> Items { get; private set; }

    public BackpackAggregate(Guid id, Guid characterId, List<CharacterItem>? items = null)
    {
        Id = id;
        CharacterId = characterId;
        Items = items ?? new List<CharacterItem>();
    }

    public BackpackAggregate(BaseDataModel baseDataModel) : base(baseDataModel)
    {
        var parsedDataModel = baseDataModel as BackpackDataModel;
        
        Id = parsedDataModel.Id;
        CharacterId = parsedDataModel.CharacterId;
        Items = parsedDataModel.Items.Select(i => new CharacterItem(i)).ToList();
    }

    public void AddItem(Item item, int quantity)
    {
        if (Items.Any(x => x.Item.Id.Equals(item.Id)))
        {
            int originalQuantity = Items.First(x => x.Item.Id.Equals(item.Id)).Quantity;

            quantity += originalQuantity;
            
            RemoveItem(item.Id);
        }
        
        CharacterItem characterItem = new(item, quantity);
        Items.Add(characterItem);
    }

    public void RemoveItem(Guid itemId)
    {
        CharacterItem? item = Items.FirstOrDefault(i => i.Item.Id == itemId);
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