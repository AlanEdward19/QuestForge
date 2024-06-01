using QuestForge.CharacterService.Core.Common.ValueObjects;

namespace QuestForge.CharacterService.Core.Common.DataModels;

public class RaceAbilityScoreDataModel
{
    [Key]
    public Guid Id { get; private set; }
    public Guid RaceId { get; private set; }
    public Guid AbilityScoreId { get; private set; }
    
    [ForeignKey(nameof(RaceId))]
    public virtual RaceDataModel Race { get; private set; }
    
    [ForeignKey(nameof(AbilityScoreId))]
    public virtual AbilityScoreValueObject AbilityScore { get; private set; }

    public RaceAbilityScoreDataModel() { }

    public RaceAbilityScoreDataModel(Guid raceId,  AbilityScoreValueObject abilityScoreValueObject)
    {
        Id = Guid.NewGuid();
        RaceId = raceId;
        AbilityScoreId = abilityScoreValueObject.Id;
        AbilityScore = abilityScoreValueObject;
    }
}