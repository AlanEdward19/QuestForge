namespace QuestForge.CharacterService.Core.Commons.DataModels;

public class ClassDataModel
{
    [Key]
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int HitDie { get; private set; }
    
}