﻿using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Core.Common.DataModels;

public class ItemDataModel : BaseDataModel
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public EItemType Type { get; private set; }
    public double Value { get; private set; }
    public ECurrencyType CurrencyType { get; private set; }
    public double Weight { get; private set; }

    public ItemDataModel() { }

    public ItemDataModel(string name, string description, EItemType type, double value, ECurrencyType currencyType, double weight) : base(Guid.NewGuid())
    {
        Name = name;
        Description = description;
        Type = type;
        Value = value;
        CurrencyType = currencyType;
        Weight = weight;
    }
}