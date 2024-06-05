using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Characters.Aggregates.Background;
using QuestForge.CharacterService.Core.Characters.Aggregates.Backpack;
using QuestForge.CharacterService.Core.Characters.Aggregates.Race;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.ValueObjects;
using QuestForge.CharacterService.Core.Items.Entities;

namespace QuestForge.CharacterService.Core.Characters.Aggregates;

public class CharacterAggregateRoot(Character character, RaceAggregate race, Class @class, BackpackAggregate backpack, Level level, BackgroundAggregate background)
    : ValueObject
{
    [JsonPropertyName("Basic Information")]
    public Character Character { get; private set; } = character;

    [JsonPropertyName("Race Information")]
    public RaceAggregate Race { get; private set; } = race;

    [JsonPropertyName("Class Information")]
    public Class Class { get; private set; } = @class;

    [JsonPropertyName("Backpack Information")]
    public BackpackAggregate Backpack { get; private set; } = backpack;

    [JsonPropertyName("Level Information")]
    public Level Level { get; private set; } = level;

    [JsonPropertyName("Background Information")]
    public BackgroundAggregate Background { get; private set; } = background;

    public CharacterDataModel BuildClassDataModel()
    {
        return new(Character.Id, Character.Name, Character.Height, Character.Weight, Character.Age,
            Character.AppearanceDescription, Character.BackgroundDescription, Race.Id, Class.Id,
            AbilityScoreValueObject.BuildFromDictionary(Character.AbilityScores), Backpack.Id,
            Level.Id, Character.CoinPurse.Id, Background.Id);
    }
}