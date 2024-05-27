namespace QuestForge.CharacterService.Core.Commons.DataModels;

public class LevelDataModel
{
    [Key]
    public Guid Id { get; private set; }
    public int Level { get; private set; }
    public int ExperiencePoints { get; private set; }
    public int ExperiencePointsToNextLevel { get; private set; }

    public LevelDataModel() { }

    public LevelDataModel(Guid id, int level, int experiencePoints, int experiencePointsToNextLevel)
    {
        Id = id;
        Level = level;
        ExperiencePoints = experiencePoints;
        ExperiencePointsToNextLevel = experiencePointsToNextLevel;
    }
}