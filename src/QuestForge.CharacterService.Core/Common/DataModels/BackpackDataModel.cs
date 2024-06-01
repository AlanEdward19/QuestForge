using QuestForge.CharacterService.Core.Common.Abstracts.Base;

namespace QuestForge.CharacterService.Core.Common.DataModels;

public class BackpackDataModel : BaseDataModel
{
    public Guid CharacterId { get; private set; }
    public List<PlayerItemDataModel> Items { get; private set; }

    public BackpackDataModel() { }
    
    public BackpackDataModel(Guid id, Guid characterId) : base(id)
    {
        CharacterId = characterId;
        Items = new List<PlayerItemDataModel>();
    }
}