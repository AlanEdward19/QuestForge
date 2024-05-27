namespace QuestForge.CharacterService.Core.Races.Entities;

public class Race(Guid id, string name, string description)
{
    public Guid Id { get; private set; } = id;
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
}