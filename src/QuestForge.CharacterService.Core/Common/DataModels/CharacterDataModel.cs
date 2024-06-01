using QuestForge.CharacterService.Core.Characters.Enums;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.ValueObjects;

namespace QuestForge.CharacterService.Core.Common.DataModels;

public class CharacterDataModel : BaseDataModel
{
    public string Name { get; private set; }
    public double Height { get; private set; }
    public double Weight { get; private set; }
    public int Age { get; private set; }
    public string AppearanceDescription { get; private set; }
    public string BackgroundDescription { get; private set; }
    public Guid RaceId { get; private set; }
    public Guid ClassId { get; private set; }
    public virtual List<CharacterAbilityScoreDataModel> AbilityScores { get; private set; }
    public Guid BackpackId { get; private set; }
    public Guid LevelId { get; private set; }

    [ForeignKey(nameof(RaceId))] public virtual RaceDataModel Race { get; private set; }

    [ForeignKey(nameof(ClassId))] public virtual ClassDataModel Class { get; private set; }

    [ForeignKey(nameof(BackpackId))] public virtual BackpackDataModel Backpack { get; private set; }

    [ForeignKey(nameof(LevelId))] public virtual LevelDataModel Level { get; private set; }

    public CharacterDataModel() { }

    public CharacterDataModel(Guid id, string name, double height, double weight, int age, string appearanceDescription,
        string backgroundDescription, Guid raceId, Guid classId, List<AbilityScoreValueObject> abilityScores,
        Guid backpackId, Guid levelId) : base(id)
    {
        Name = name;
        Height = height;
        Weight = weight;
        Age = age;
        AppearanceDescription = appearanceDescription;
        BackgroundDescription = backgroundDescription;
        RaceId = raceId;
        ClassId = classId;
        AbilityScores = abilityScores
            .Select(x => new CharacterAbilityScoreDataModel(Id, x))
            .ToList();
        BackpackId = backpackId;
        LevelId = levelId;
    }

    public override void UpdateBasedOnValueObject(ValueObject valueObject)
    {
        base.UpdateBasedOnValueObject(valueObject);
    }
}