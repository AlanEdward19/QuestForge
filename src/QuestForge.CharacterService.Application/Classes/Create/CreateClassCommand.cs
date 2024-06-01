using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Classes.Create;

public class CreateClassCommand(string name, string description, int hitDie) : Command
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
    public int HitDie { get; private set; } = hitDie;
}