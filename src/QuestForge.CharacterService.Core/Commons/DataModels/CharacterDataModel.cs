using QuestForge.CharacterService.Core.Characters.Enums;

namespace QuestForge.CharacterService.Core.Commons.DataModels;

public class CharacterDataModel
{
    [Key]
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public Guid RaceId { get; private set; }
    public Guid ClassId { get; private set; }
    public Dictionary<EAbilityScore, int> AbilityScores { get; private set; }
    public Guid BackpackId { get; private set; }
    public Guid LevelId { get; private set; }
    
    [ForeignKey(nameof(RaceId))]
    public virtual RaceDataModel Race { get; private set; }
    
    [ForeignKey(nameof(ClassId))]
    public virtual ClassDataModel Class { get; private set; }
    
    [ForeignKey(nameof(BackpackId))]
    public virtual BackpackDataModel Backpack { get; private set; }
    
    [ForeignKey(nameof(LevelId))]
    public virtual LevelDataModel Level { get; private set; }

    public CharacterDataModel() { }

    public CharacterDataModel(Guid id, string name, Guid raceId, Guid classId, Dictionary<EAbilityScore, int> abilityScores, Guid backpackId, Guid levelId)
    {
        Id = id;
        Name = name;
        RaceId = raceId;
        ClassId = classId;
        AbilityScores = abilityScores;
        BackpackId = backpackId;
        LevelId = levelId;
    }
}