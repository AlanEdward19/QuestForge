using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Items.Entities;
using QuestForge.CharacterService.Core.Items.Enums;

namespace QuestForge.CharacterService.Core.Common.DataModels;

public class ArmorDataModel : ItemDataModel
{
    public int ArmorClass { get; private set; }
    public EArmorProficiency ArmorType { get; private set; }
    public EAbility? Modifier { get; private set; }
    public int MaxModifier { get; private set; }
    public int MinStrength { get; private set; }
    public bool StealthDisadvantage { get; private set; }

    public ArmorDataModel() : base(){ }

    public ArmorDataModel(EArmorProficiency type, int armorClass, EAbility? modifier, int maxModifier, int minStrength, bool stealthDisadvantage, string name, string description,
        double value, ECurrencyType currencyType, double weight) : base(name, description, EItemType.Armor, value, currencyType, weight)
    {
        ArmorType = type;
        ArmorClass = armorClass;
        Modifier = modifier;
        MaxModifier = maxModifier;
        MinStrength = minStrength;
        StealthDisadvantage = stealthDisadvantage;
    }

    public override void UpdateBasedOnValueObject(ValueObject valueObject)
    {
        var parsedValueObject = valueObject as Armor;

        ArmorType = parsedValueObject!.ArmorType;
        ArmorClass = parsedValueObject.ArmorClass;
        Modifier = parsedValueObject.Modifier;
        MaxModifier = parsedValueObject.MaxModifier;
        MinStrength = parsedValueObject.MinStrength;
        StealthDisadvantage = parsedValueObject.StealthDisadvantage;

        base.UpdateBasedOnValueObject(valueObject);
    }
}