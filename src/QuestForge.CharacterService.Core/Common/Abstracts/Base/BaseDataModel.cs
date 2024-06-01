namespace QuestForge.CharacterService.Core.Common.Abstracts.Base;

public abstract class BaseDataModel
{
    [Key]
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }

    public BaseDataModel() { }

    protected BaseDataModel(Guid id)
    {
        Id = id;
        CreatedAt = DateTime.Now;
        UpdatedAt = CreatedAt;
    }

    public virtual void UpdateBasedOnValueObject(ValueObject valueObject) => UpdatedAt = DateTime.Now;
}