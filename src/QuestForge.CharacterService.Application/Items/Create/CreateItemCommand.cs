﻿using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Application.Items.Create;

public class CreateItemCommand(
    string name,
    string description,
    EItemType type,
    double value,
    ECurrencyType currencyType,
    double weight) : Command
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
    public EItemType Type { get; private set; } = type;
    public double Value { get; private set; } = value;
    public ECurrencyType CurrencyType { get; private set; } = currencyType;
    public double Weight { get; private set; } = weight;
}