using QuestForge.CharacterService.Core.Common.Abstracts.Base;

namespace QuestForge.CharacterService.Core.Common.DataModels;

public class LevelDataModel : BaseDataModel
{
    public Guid CharacterId { get; private set; }
    public int Level { get; private set; }
    public int ExperiencePoints { get; private set; }
    public int ExperiencePointsToNextLevel { get; private set; }

    public LevelDataModel() { }

    public LevelDataModel(Guid id, Guid characterId, int level, int experiencePoints, int experiencePointsToNextLevel) : base(id)
    {
        CharacterId = characterId;
        Level = level;
        ExperiencePoints = experiencePoints;
        ExperiencePointsToNextLevel = experiencePointsToNextLevel;
    }
}