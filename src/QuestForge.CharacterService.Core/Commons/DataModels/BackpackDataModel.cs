namespace QuestForge.CharacterService.Core.Commons.DataModels;

public class BackpackDataModel
{
    [Key]
    public Guid Id { get; private set; }
    public List<PlayerItem> Items { get; private set; }

    public BackpackDataModel()
    {
        Id = Guid.NewGuid();
        Items = new List<PlayerItem>();
    }
}