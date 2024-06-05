using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Entities;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Core.Common.DataModels;

public class PotionDataModel : ItemDataModel
{
    public int Dice { get; set; }
    public int DiceCount { get; set; }
    public int Bonus { get; set; }
    public EPotionEffect Effect { get; set; }

    public PotionDataModel(int dice, int diceCount, int bonus, EPotionEffect effect, string name, string description, 
        double value, ECurrencyType currencyType, double weight) : base(name, description, EItemType.Potion, value, currencyType, weight)
    {
        Dice = dice;
        DiceCount = diceCount;
        Bonus = bonus;
        Effect = effect;
    }

    public PotionDataModel() : base() { }

    public override void UpdateBasedOnValueObject(ValueObject valueObject)
    {
        var parsedValueObject = valueObject as Potion;

        Dice = parsedValueObject!.Dice;
        DiceCount = parsedValueObject.DiceCount;
        Bonus = parsedValueObject.Bonus;
        Effect = parsedValueObject.Effect;

        base.UpdateBasedOnValueObject(valueObject);
    }
}