using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Characters.Items.Delete;

public class DeleteCharacterItemCommand(Guid characterId, Guid itemId, int quantity) : Command
{
    public Guid CharacterId { get; private set; } = characterId;
    public Guid ItemId { get; private set; } = itemId;
    public int Quantity { get; private set; } = quantity;
}