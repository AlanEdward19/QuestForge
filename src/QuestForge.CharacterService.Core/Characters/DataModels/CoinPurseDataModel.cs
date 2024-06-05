using QuestForge.CharacterService.Core.Characters.Aggregates;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;

namespace QuestForge.CharacterService.Core.Characters.DataModels;

public class CoinPurseDataModel : BaseDataModel
{
    public int Gold { get; private set; }
    public int Silver { get; private set; }
    public int Copper { get; private set;}

    public CoinPurseDataModel() : base() { }

    public CoinPurseDataModel(Guid id, int gold, int silver, int copper) : base(id)
    {
        Gold = gold;
        Silver = silver;
        Copper = copper;
    }
    public override void UpdateBasedOnValueObject(ValueObject valueObject)
    {
        var parsedValueObject = valueObject as CoinPurse;

        Gold = parsedValueObject.Gold;
        Silver = parsedValueObject.Silver;
        Copper = parsedValueObject.Copper;

        base.UpdateBasedOnValueObject(valueObject);
    }
}