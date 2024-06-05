using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Core.Characters.DataModels;

public class PlayerItemDataModel
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

    public PlayerItemDataModel() { }

    public PlayerItemDataModel(Guid id, Guid itemId, Guid characterId, int quantity, bool isEquipped)
    {
        Id = id;
        ItemId = itemId;
        CharacterId = characterId;
        Quantity = quantity;
        IsEquipped = isEquipped;
    }
}