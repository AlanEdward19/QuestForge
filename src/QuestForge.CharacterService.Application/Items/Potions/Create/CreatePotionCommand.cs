using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Items.Enums;

namespace QuestForge.CharacterService.Application.Items.Potions.Create;

public class CreatePotionCommand(
    string name,
    string description,
    int dice,
    int diceCount,
    int bonus,
    EPotionEffect effect,
    double value,
    ECurrencyType currencyType,
    double weight) : Command
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
    public int Dice { get; private set; } = dice;
    public int DiceCount { get; private set; } = diceCount;
    public int Bonus { get; private set; } = bonus;
    public EPotionEffect Effect { get; private set; } = effect;
    public double Value { get; private set; } = value;
    public ECurrencyType CurrencyType { get; private set; } = currencyType;
    public double Weight { get; private set; } = weight;
}