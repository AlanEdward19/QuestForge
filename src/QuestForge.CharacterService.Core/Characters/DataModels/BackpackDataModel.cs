using QuestForge.CharacterService.Core.Characters.Aggregates.Backpack;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;

namespace QuestForge.CharacterService.Core.Characters.DataModels;

public class BackpackDataModel : BaseDataModel
{
    public Guid CharacterId { get; private set; }
    public List<CharacterItemDataModel> Items { get; private set; }
    
    [ForeignKey(nameof(CharacterId))]
    public virtual CharacterDataModel Character { get; private set; }

    public BackpackDataModel() { }

    public BackpackDataModel(Guid id, Guid characterId) : base(id)
    {
        CharacterId = characterId;
        Items = new List<CharacterItemDataModel>();
    }

    public override void UpdateBasedOnValueObject(ValueObject valueObject)
    {
        var parsedValueObject = valueObject as BackpackAggregate;

        var newItems = parsedValueObject.Items
            .Select(i => i.BuildClassDataModel(Id))
            .ToList();

        Items = new();
        Items.AddRange(newItems);
        
        base.UpdateBasedOnValueObject(valueObject);
    }
}