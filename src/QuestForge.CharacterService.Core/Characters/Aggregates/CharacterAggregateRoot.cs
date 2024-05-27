using QuestForge.CharacterService.Core.Characters.Entities;
using QuestForge.CharacterService.Core.Characters.Enums;

namespace QuestForge.CharacterService.Core.Characters.Aggregates;

public class CharacterAggregateRoot
{
    public Character Character { get; private set; }
    public Race Race { get; private set; }
    public Class Class { get; private set; }
    public Dictionary<EAbilityScore, int> AbilityScores { get; private set; }
    public Backpack Backpack { get; private set; }
    public Level Level { get; private set; }

    public CharacterAggregateRoot(Character character, Race race, Class @class, Dictionary<EAbilityScore, int> abilityScores, Backpack backpack, Level level)
    {
        Character = character;
        Race = race;
        Class = @class;
        AbilityScores = abilityScores;
        Backpack = backpack;
        Level = level;
    }
}