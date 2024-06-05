using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Characters.Create;

public class CreateCharacterCommand(
    string name,
    double height,
    double weight,
    int age,
    string appearanceDescription,
    string backgroundDescription,
    Guid raceId,
    Guid classId,
    Guid backgroundId) : Command
{
    public string Name { get; private set; } = name;
    public double Height { get; private set; } = height;
    public double Weight { get; private set; } = weight;
    public int Age { get; private set; } = age;
    public string AppearanceDescription { get; private set; } = appearanceDescription;
    public string BackgroundDescription { get; private set; } = backgroundDescription;
    public Guid RaceId { get; private set; } = raceId;
    public Guid ClassId { get; private set; } = classId;
    public Guid BackgroundId { get; private set; } = backgroundId;
}