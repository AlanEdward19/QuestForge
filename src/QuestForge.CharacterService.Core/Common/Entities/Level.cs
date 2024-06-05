using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Core.Common.Entities;

public class Level(Guid id, Guid characterId, int number, int experiencePoints, int experiencePointsToNextLevel)
    : ValueObject
{
    [JsonIgnore]
    public Guid Id { get; private set; } = id;
    [JsonIgnore]
    public Guid CharacterId { get; private set; } = characterId;
    public int Number { get; private set; } = number;
    public int ExperiencePoints { get; private set; } = experiencePoints;
    public int ExperiencePointsToNextLevel { get; private set; } = experiencePointsToNextLevel;

    public LevelDataModel BuildClassDataModel()
    {
        return new(Id, CharacterId, Number, ExperiencePoints, ExperiencePointsToNextLevel);
    }
}