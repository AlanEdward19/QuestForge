using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Characters.Items.Create;

public class GiveCharacterItemCommand(Guid characterId, Guid itemId, int quantity) : Command
{
    public Guid CharacterId { get; private set; } = characterId;
    public Guid ItemId { get; private set; } = itemId;
    public int Quantity { get; private set; } = quantity;
}