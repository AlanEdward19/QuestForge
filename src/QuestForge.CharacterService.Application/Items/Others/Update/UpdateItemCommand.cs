﻿using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Items.Enums;

namespace QuestForge.CharacterService.Application.Items.Others.Update;

public class UpdateItemCommand(
    string? name,
    string? description,
    double? value,
    ECurrencyType? currencyType,
    double? weight) : Command
{
    public Guid Id { get; private set; }
    public string? Name { get; private set; } = name;
    public string? Description { get; private set; } = description;
    public EItemType Type { get; private set; }
    public double? Value { get; private set; } = value;
    public ECurrencyType? CurrencyType { get; private set; } = currencyType;
    public double? Weight { get; private set; } = weight;

    public void SetType(EItemType type) => Type = type;
    public void SetId(Guid id) => Id = id;
}