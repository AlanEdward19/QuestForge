namespace QuestForge.CharacterService.Core.Commons.DataModels;

public class ItemDataModel
{
    [Key]
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public EItemType Type { get; private set; }
    public double Value { get; private set; }
    public ECurrencyType CurrencyType { get; private set; }
    public double Weight { get; private set; }

    public ItemDataModel() { }

    public ItemDataModel(Guid id, string name, string description, EItemType type, double value, ECurrencyType currencyType, double weight)
    {
        Id = id;
        Name = name;
        Description = description;
        Type = type;
        Value = value;
        CurrencyType = currencyType;
        Weight = weight;
    }
}