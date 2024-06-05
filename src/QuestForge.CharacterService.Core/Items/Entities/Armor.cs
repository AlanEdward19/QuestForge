using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Items.Enums;

namespace QuestForge.CharacterService.Core.Items.Entities;

public class Armor : Item
{
    public int ArmorClass { get; private set; }
    public EArmorProficiency ArmorType { get; private set; }
    public EAbility? Modifier { get; private set; }
    public int MaxModifier { get; private set; }
    public int MinStrength { get; private set; }
    public bool StealthDisadvantage { get; private set; }

    public Armor() : base() { }

    public Armor(int armorClass, EArmorProficiency armorType, EAbility? modifier, int maxModifier, int minStrength, bool stealthDisadvantage,
        Guid id, string name, string description, EItemType type,
        ECurrencyType currencyType, double value, double weight) : base(id, name, description, type, currencyType, value, weight)
    {
        ArmorClass = armorClass;
        ArmorType = armorType;
        Modifier = modifier;
        MaxModifier = maxModifier;
        MinStrength = minStrength;
        StealthDisadvantage = stealthDisadvantage;
    }

    public Armor(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as ArmorDataModel;

        ArmorClass = parsedDataModel.ArmorClass;
        ArmorType = parsedDataModel.ArmorType;
        Modifier = parsedDataModel.Modifier;
        MaxModifier = parsedDataModel.MaxModifier;
        MinStrength = parsedDataModel.MinStrength;
        StealthDisadvantage = parsedDataModel.StealthDisadvantage;
    }

    public void UpdateArmorClass(int? armorClass)
    {
        if (armorClass.HasValue && !ArmorClass.Equals(armorClass))
            ArmorClass = armorClass.Value;
    }

    public void UpdateArmorType(EArmorProficiency? armorType)
    {
        if (armorType.HasValue && !ArmorType.Equals(armorType))
            ArmorType = armorType.Value;
    }

    public void UpdateModifier(EAbility? modifier)
    {
        if (modifier.HasValue && !Modifier.Equals(modifier))
            Modifier = modifier.Value;
    }

    public void UpdateMaxModifier(int? maxModifier)
    {
        if (maxModifier.HasValue && !MaxModifier.Equals(maxModifier))
            MaxModifier = maxModifier.Value;
    }

    public void UpdateMinStrength(int? minStrength)
    {
        if (minStrength.HasValue && !MinStrength.Equals(minStrength))
            MinStrength = minStrength.Value;
    }

    public void UpdateStealthDisadvantage(bool? stealthDisadvantage)
    {
        if (stealthDisadvantage.HasValue && !StealthDisadvantage.Equals(stealthDisadvantage))
            StealthDisadvantage = stealthDisadvantage.Value;
    }
}