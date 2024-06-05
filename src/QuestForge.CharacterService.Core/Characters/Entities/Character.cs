using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Common.ValueObjects;

namespace QuestForge.CharacterService.Core.Characters.Entities;

public class Character : ValueObject
{
    [JsonIgnore]
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public double Height { get; private set; }
    public double Weight { get; private set; }
    public int Age { get; private set; }
    public string AppearanceDescription { get; private set; }
    public string BackgroundDescription { get; private set; }
    public Dictionary<EAbility, int> AbilityScores { get; private set; }

    public Character(Guid id, string name, double height, double weight, int age, string appearanceDescription,
        string backgroundDescription, Dictionary<EAbility, int> abilityScores)
    {
        Id = id;
        Name = name;
        Height = height;
        Weight = weight;
        Age = age;
        AppearanceDescription = appearanceDescription;
        BackgroundDescription = backgroundDescription;
        AbilityScores = abilityScores;
    }

    public Character(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as CharacterDataModel;

        Id = parsedDataModel!.Id;
        Name = parsedDataModel.Name;
        Height = parsedDataModel.Height;
        Weight = parsedDataModel.Weight;
        Age = parsedDataModel.Age;
        AppearanceDescription = parsedDataModel.AppearanceDescription;
        BackgroundDescription = parsedDataModel.BackgroundDescription;
        AbilityScores = AbilityScoreValueObject
                .BuildFromValueObjects(parsedDataModel.AbilityScores
                .Select(x => x.AbilityScore)
                .ToList());
    }
}