using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Core.Common.Entities;

public class Item(Guid id, string name, string description, EItemType type, ECurrencyType currencyType, double value)
{
    public Guid Id { get; private set; } = id;
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
    public EItemType Type { get; private set; } = type;
    public ECurrencyType CurrencyType { get; private set; } = currencyType;
    public double Value { get; private set; } = value;
}