using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Application.Items.Armors.Create;

public class CreateArmorCommand(
    string name,
    string description,
    int armorClass,
    EArmorProficiency armorType,
    EAbility? modifier,
    int maxModifier,
    int minStrength,
    bool stealthDisadvantage,
    EItemType type,
    double value,
    ECurrencyType currencyType,
    double weight) : Command
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
    public int ArmorClass { get; private set; } = armorClass;
    public EArmorProficiency ArmorType { get; private set; } = armorType;
    public EAbility? Modifier { get; private set; } = modifier;
    public int MaxModifier { get; private set; } = maxModifier;
    public int MinStrength { get; private set; } = minStrength;
    public bool StealthDisadvantage { get; private set; } = stealthDisadvantage;
    public EItemType Type { get; private set; } = type;
    public double Value { get; private set; } = value;
    public ECurrencyType CurrencyType { get; private set; } = currencyType;
    public double Weight { get; private set; } = weight;
}