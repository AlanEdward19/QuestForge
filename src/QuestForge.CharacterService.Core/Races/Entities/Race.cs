using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Characters.Enums;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Common.ValueObjects;

namespace QuestForge.CharacterService.Core.Races.Entities;

public class Race : ValueObject
{
    [JsonIgnore]
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public double Movement { get; private set; }
    public Dictionary<EAbilityScore, int> AbilityScoreIncrease { get; private set; }

    public Race(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as RaceDataModel;
        
        Id = parsedDataModel!.Id;
        Name = parsedDataModel!.Name;
        Description = parsedDataModel.Description;
        AbilityScoreIncrease =
            AbilityScoreValueObject.BuildFromValueObjects(parsedDataModel.AbilityScoreIncrease
                .Select(x => x.AbilityScore).ToList());
        Movement = parsedDataModel.Movement;
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
    
    public void UpdateAbilityScoreIncrease(Dictionary<EAbilityScore, int>? abilityScoreIncrease)
    {
        if (abilityScoreIncrease != null && abilityScoreIncrease.Count != 0 && !AbilityScoreIncrease.Equals(abilityScoreIncrease))
            AbilityScoreIncrease = abilityScoreIncrease;
    }

    public void UpdateMovement(double? movement)
    {
        if (movement != null && !Movement.Equals(movement))
            Movement = movement.Value;
    }
}