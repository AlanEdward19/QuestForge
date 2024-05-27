namespace QuestForge.CharacterService.Core.Characters.Aggregates;

public class Race(Guid id, string name, string description)
{
    public Guid Id { get; private set; } = id;
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
}