using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;

namespace QuestForge.CharacterService.Core.Items.Entities;

public class Level : ValueObject
{
    [JsonIgnore]
    public Guid Id { get; private set; }
    [JsonIgnore]
    public Guid CharacterId { get; private set; }
    public int Number { get; private set; }
    public int ExperiencePoints { get; private set; }
    public int ExperiencePointsToNextLevel { get; private set; }

    public Level(Guid id, Guid characterId, int number, int experiencePoints, int experiencePointsToNextLevel)
    {
        Id = id;
        CharacterId = characterId;
        Number = number;
        ExperiencePoints = experiencePoints;
        ExperiencePointsToNextLevel = experiencePointsToNextLevel;
    }
    
    public Level(BaseDataModel baseDataModel) : base(baseDataModel)
    {
        var levelDataModel = baseDataModel as LevelDataModel;
        
        Id = levelDataModel.Id;
        CharacterId = levelDataModel.CharacterId;
        Number = levelDataModel.Level;
        ExperiencePoints = levelDataModel.ExperiencePoints;
        ExperiencePointsToNextLevel = levelDataModel.ExperiencePointsToNextLevel;
    }

    public LevelDataModel BuildClassDataModel()
    {
        return new(Id, CharacterId, Number, ExperiencePoints, ExperiencePointsToNextLevel);
    }
}