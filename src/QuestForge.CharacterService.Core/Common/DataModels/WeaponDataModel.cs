using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Entities;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Core.Common.DataModels;

public class WeaponDataModel : ItemDataModel
{
    public int Dice { get; set; }
    public EDamageType DamageType { get; set; }
    public int DiceCount { get; set; }

    public WeaponDataModel() : base() { }

    public WeaponDataModel(int dice, EDamageType damageType, int diceCount, string name, string description, double value, ECurrencyType currencyType, double weight) 
        : base(name, description, EItemType.Weapon, value, currencyType, weight)
    {
        Dice = dice;
        DamageType = damageType;
        DiceCount = diceCount;
    }

    public override void UpdateBasedOnValueObject(ValueObject valueObject)
    {
        var parsedValueObject = valueObject as Weapon;

        Dice = parsedValueObject!.Dice;
        DamageType = parsedValueObject.DamageType;
        DiceCount = parsedValueObject.DiceCount;

        base.UpdateBasedOnValueObject(valueObject);
    }
}