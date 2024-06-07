using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Characters.Items.AddItem;

public class AddCharacterItemCommand(Guid characterId, Guid itemId, int quantity) : Command
{
    public Guid CharacterId { get; private set; } = characterId;
    public Guid ItemId { get; private set; } = itemId;
    public int Quantity { get; private set; } = quantity;
}