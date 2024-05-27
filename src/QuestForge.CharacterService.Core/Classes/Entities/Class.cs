namespace QuestForge.CharacterService.Core.Classes.Entities;

public class Class(Guid id, string name)
{
    public Guid Id { get; private set; } = id;
    public string Name { get; private set; } = name;
}