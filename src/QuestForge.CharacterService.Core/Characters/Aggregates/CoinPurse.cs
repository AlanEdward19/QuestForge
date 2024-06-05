using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Core.Characters.Aggregates;

public class CoinPurse: ValueObject
{
    [JsonIgnore]
    public Guid Id { get; private set; }
    public int Gold { get; private set; }
    public int Silver { get; private set; }
    public int Copper { get; private set; }

    public CoinPurse(int gold, int silver, int copper)
    {
        Id = Guid.NewGuid();
        Gold = gold;
        Silver = silver;
        Copper = copper;
    }

    public CoinPurse()
    {
        Id = Guid.NewGuid();
        Gold = 0;
        Silver = 0;
        Copper = 0;
    }

    public CoinPurse(BaseDataModel baseDataModel) : base(baseDataModel)
    {
        var parsedDataModel = baseDataModel as CoinPurseDataModel;

        Id = parsedDataModel.Id;
        Gold = parsedDataModel.Gold;
        Silver = parsedDataModel.Silver;
        Copper = parsedDataModel.Copper;
    }

    public CoinPurseDataModel BuildClassDataModel()
    {
        return new(Id, Gold, Silver, Copper);
    }

    public void AddCoin(ECurrencyType type, int amount)
    {
        switch (type)
        {
            case ECurrencyType.Gold:
                Gold += amount;
                break;
            case ECurrencyType.Silver:
                Silver += amount;
                break;
            case ECurrencyType.Copper:
                Copper += amount;
                break;
        }
    }
}