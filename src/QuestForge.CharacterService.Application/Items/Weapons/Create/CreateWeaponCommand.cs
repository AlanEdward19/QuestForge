using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Items.Enums;

namespace QuestForge.CharacterService.Application.Items.Weapons.Create;

public class CreateWeaponCommand(
    string name,
    string description,
    int dice,
    EDamageType damageType,
    int diceCount,
    double value,
    ECurrencyType currencyType,
    double weight) : Command
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
    public int Dice { get; private set; } = dice;
    public EDamageType DamageType { get; private set; } = damageType;
    public int DiceCount { get; private set; } = diceCount;
    public double Value { get; private set; } = value;
    public ECurrencyType CurrencyType { get; private set; } = currencyType;
    public double Weight { get; private set; } = weight;
}