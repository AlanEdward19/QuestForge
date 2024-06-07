using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Items.Enums;
using QuestForge.CharacterService.Core.Utils.Converters;

namespace QuestForge.CharacterService.Core.Items.Entities;

public class Item : ValueObject
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    [JsonConverter(typeof(EnumToStringConverter<EItemType>))]
    public EItemType Type { get; private set; }
    [JsonConverter(typeof(EnumToStringConverter<ECurrencyType>))]
    public ECurrencyType CurrencyType { get; private set; }
    public double Value { get; private set; }
    public double Weight { get; private set; }

    public Item() { }

    public Item(Guid id, string name, string description, EItemType type, ECurrencyType currencyType, double value, double weight) : base()
    {
        Id = id;
        Name = name;
        Description = description;
        Type = type;
        CurrencyType = currencyType;
        Value = value;
        Weight = weight;
    }

    public Item(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as ItemDataModel;

        Id = parsedDataModel.Id;
        Name = parsedDataModel.Name;
        Description = parsedDataModel.Description;
        Type = parsedDataModel.Type;
        CurrencyType = parsedDataModel.CurrencyType;
        Value = parsedDataModel.Value;
        Weight = parsedDataModel.Weight;
    }

    public void UpdateName(string? name)
    {
        if (!string.IsNullOrWhiteSpace(name) && !Name.Equals(name))
            Name = name;
    }

    public void UpdateDescription(string? description)
    {
        if (!string.IsNullOrWhiteSpace(description) && !Description.Equals(description))
            Description = description;
    }

    public void UpdateValue(double? value)
    {
        if (value.HasValue && !Value.Equals(value))
            Value = value.Value;
    }

    public void UpdateCurrencyType(ECurrencyType? currencyType)
    {
        if (currencyType.HasValue && !CurrencyType.Equals(currencyType))
            CurrencyType = currencyType.Value;
    }

    public void UpdateWeight(double? weight)
    {
        if (weight.HasValue && !Weight.Equals(weight))
            Weight = weight.Value;
    }

    public void UpdateType(EItemType? type)
    {
        if (type.HasValue && !Type.Equals(type))
            Type = type.Value;
    }
}