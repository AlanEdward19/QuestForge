using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Characters.Entities;
using QuestForge.CharacterService.Core.Characters.Enums;
using QuestForge.CharacterService.Core.Classes.Entities;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Common.Entities;
using QuestForge.CharacterService.Core.Common.ValueObjects;
using QuestForge.CharacterService.Core.Races.Entities;

namespace QuestForge.CharacterService.Core.Characters.Aggregates;

public class CharacterAggregateRoot : ValueObject
{
    [JsonPropertyName("Basic Information")]
    public Character Character { get; private set; }
    [JsonPropertyName("Race Information")]
    public Race Race { get; private set; }
    [JsonPropertyName("Class Information")]
    public Class Class { get; private set; }
    [JsonPropertyName("Backpack Information")]
    public Backpack Backpack { get; private set; }
    [JsonPropertyName("Level Information")]
    public Level Level { get; private set; }

    public CharacterAggregateRoot(Character character, Race race, Class @class, Backpack backpack, Level level)
    {
        Character = character;
        Race = race;
        Class = @class;
        Backpack = backpack;
        Level = level;
    }

    public CharacterDataModel BuildClassDataModel()
    {
        return new(Character.Id, Character.Name, Character.Height, Character.Weight, Character.Age,
            Character.AppearanceDescription, Character.BackgroundDescription, Race.Id, Class.Id,
            AbilityScoreValueObject.BuildFromDictionary(Character.AbilityScores), Backpack.Id,
            Level.Id);
    }
}