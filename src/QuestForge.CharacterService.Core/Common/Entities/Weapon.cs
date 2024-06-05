using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Core.Common.Entities;

public class Weapon : Item
{
    public int Dice { get; private set; }
    public EDamageType DamageType { get; private set; }
    public int DiceCount { get; private set; }

    public Weapon() : base() { }

    public Weapon(int dice, EDamageType damageType, int diceCount, Guid id, string name, string description, EItemType type, ECurrencyType currencyType, double value, double weight) 
        : base(id, name, description, type, currencyType, value, weight)
    {
        Dice = dice;
        DamageType = damageType;
        DiceCount = diceCount;
    }

    public Weapon(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as WeaponDataModel;

        Dice = parsedDataModel.Dice;
        DamageType = parsedDataModel.DamageType;
        DiceCount = parsedDataModel.DiceCount;
    }

    public void UpdateDice(int? dice)
    {
        if (dice.HasValue && !Dice.Equals(dice))
            Dice = dice.Value;
    }

    public void UpdateDamageType(EDamageType? damageType)
    {
        if (damageType.HasValue && !DamageType.Equals(damageType))
            DamageType = damageType.Value;
    }

    public void UpdateDiceCount(int? diceCount)
    {
        if (diceCount.HasValue && !DiceCount.Equals(diceCount))
            DiceCount = diceCount.Value;
    }
}