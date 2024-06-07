using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Items.Entities;

namespace QuestForge.CharacterService.Core.Characters.Aggregates.Backpack;

public class CharacterItem : ValueObject
{
    public Item Item { get; private set; }
    public int Quantity { get; private set; }

    public CharacterItem(Item item, int quantity)
    {
        Item = item;
        Quantity = quantity;
    }

    public CharacterItem(BaseDataModel baseDataModel) : base(baseDataModel)
    {
        var parsedDataModel = baseDataModel as CharacterItemDataModel;
        
        Item = new Item(parsedDataModel.Item);
        Quantity = parsedDataModel.Quantity;
    }
    
    public CharacterItemDataModel BuildClassDataModel(Guid backpackId)
    {
        return new(Guid.NewGuid(), Item.Id, backpackId, Quantity);
    }
    
    public void AddQuantity(int quantity)
    {
        Quantity += quantity;
    }
    
    public void RemoveQuantity(int quantity)
    {
        Quantity -= quantity;
    }
}