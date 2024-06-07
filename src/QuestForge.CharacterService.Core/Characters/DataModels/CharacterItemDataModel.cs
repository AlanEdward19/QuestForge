using QuestForge.CharacterService.Core.Characters.Aggregates.Backpack;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Core.Characters.DataModels;

public class CharacterItemDataModel : BaseDataModel
{
    public Guid ItemId { get; private set; }
    public Guid BackPackId { get; private set; }
    public int Quantity { get; private set; }

    [ForeignKey(nameof(ItemId))] public virtual ItemDataModel Item { get; private set; }

    [ForeignKey(nameof(BackPackId))] public virtual BackpackDataModel Backpack { get; private set; }

    public CharacterItemDataModel()
    {
    }

    public CharacterItemDataModel(Guid id, Guid itemId, Guid backPackId, int quantity) : base(id)
    {
        ItemId = itemId;
        BackPackId = backPackId;
        Quantity = quantity;
    }
    
    public CharacterItemDataModel(Guid id, Guid itemId, Guid backPackId, int quantity, ItemDataModel item) : base(id)
    {
        ItemId = itemId;
        BackPackId = backPackId;
        Quantity = quantity;
        Item = item;
    }

    public CharacterItemDataModel(Guid itemId, Guid backPackId, int quantity) : base(Guid.NewGuid())
    {
        ItemId = itemId;
        BackPackId = backPackId;
        Quantity = quantity;
    }

    public override void UpdateBasedOnValueObject(ValueObject valueObject)
    {
        var parsedValueObject = valueObject as CharacterItem;
        
        ItemId = parsedValueObject.Item.Id;
        Quantity = parsedValueObject.Quantity;
        
        base.UpdateBasedOnValueObject(valueObject);
    }
}