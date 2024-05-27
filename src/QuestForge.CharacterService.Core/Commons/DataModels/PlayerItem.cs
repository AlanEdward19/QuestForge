namespace QuestForge.CharacterService.Core.Commons.DataModels;

public class PlayerItem
{
    [Key]
    public Guid Id { get; private set; }
    public Guid ItemId { get; private set; }
    public Guid CharacterId { get; private set; }
    public int Quantity { get; private set; }
    public bool IsEquipped { get; private set; }
    
    [ForeignKey(nameof(ItemId))]
    public virtual ItemDataModel Item { get; private set; }
    
    [ForeignKey(nameof(CharacterId))]
    public virtual CharacterDataModel Character { get; private set; }

    public PlayerItem() { }

    public PlayerItem(Guid id, Guid itemId, Guid characterId, int quantity, bool isEquipped)
    {
        Id = id;
        ItemId = itemId;
        CharacterId = characterId;
        Quantity = quantity;
        IsEquipped = isEquipped;
    }
}