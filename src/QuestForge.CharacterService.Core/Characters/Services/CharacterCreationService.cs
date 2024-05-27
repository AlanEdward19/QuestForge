using QuestForge.CharacterService.Core.Characters.Aggregates;
using QuestForge.CharacterService.Core.Characters.Entities;
using QuestForge.CharacterService.Core.Characters.Enums;
using QuestForge.CharacterService.Core.Commons.Entities;

namespace QuestForge.CharacterService.Core.Characters.Services;

public class CharacterCreationService()
{
    public CharacterAggregateRoot CreateCharacter(string name, string description, Race race, Class @class, Dictionary<EAbilityScore, int> abilityScores)
    {
        Character character = new(Guid.NewGuid(), name, description);
        Backpack backpack = new(Guid.NewGuid());
        Level level = new(Guid.NewGuid(), 1, 0, 300);

        return new CharacterAggregateRoot(character, race, @class, abilityScores, backpack, level);
    }
}