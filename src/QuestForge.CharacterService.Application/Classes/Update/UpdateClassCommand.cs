using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Classes.Update;

public class UpdateClassCommand(string name, string description, int hitDie) : Command
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
    public int HitDie { get; private set; } = hitDie;
    
    public void SetId(Guid id) => Id = id;
}