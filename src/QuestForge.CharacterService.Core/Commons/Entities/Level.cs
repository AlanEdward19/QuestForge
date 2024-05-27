namespace QuestForge.CharacterService.Core.Commons.Entities;

public class Level(Guid id, int number, int experiencePoints, int experiencePointsToNextLevel)
{
    public Guid Id { get; private set; } = id;
    public int Number { get; private set; } = number;
    public int ExperiencePoints { get; private set; } = experiencePoints;
    public int ExperiencePointsToNextLevel { get; private set; } = experiencePointsToNextLevel;
}