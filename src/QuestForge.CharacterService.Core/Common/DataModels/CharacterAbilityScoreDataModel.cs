using QuestForge.CharacterService.Core.Common.ValueObjects;

namespace QuestForge.CharacterService.Core.Common.DataModels;

public class CharacterAbilityScoreDataModel
{
    [Key]
    public Guid Id { get; private set; }
    public Guid CharacterId { get; private set; }
    public Guid AbilityScoreId { get; private set; }
    
    [ForeignKey(nameof(CharacterId))]
    public virtual CharacterDataModel Character { get; private set; }
    
    [ForeignKey(nameof(AbilityScoreId))]
    public virtual AbilityScoreValueObject AbilityScore { get; private set; }

    public CharacterAbilityScoreDataModel() { }

    public CharacterAbilityScoreDataModel(Guid characterId, AbilityScoreValueObject abilityScore)
    {
        CharacterId = characterId;
        AbilityScoreId = abilityScore.Id;
        AbilityScore = abilityScore;
    }
}