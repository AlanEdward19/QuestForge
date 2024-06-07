using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Characters.Aggregates;
using QuestForge.CharacterService.Core.Characters.Aggregates.Background;
using QuestForge.CharacterService.Core.Characters.Aggregates.Backpack;
using QuestForge.CharacterService.Core.Characters.Aggregates.Race;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Classes.DataModels;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Common.ValueObjects;
using QuestForge.CharacterService.Core.Items.Entities;
using QuestForge.CharacterService.Core.Races.Aggregates;
using QuestForge.CharacterService.Core.Races.DataModels;

namespace QuestForge.CharacterService.Core.Characters.Services;

public static class CharacterCreationService
{
    public static CharacterAggregateRoot CreateCharacterBasedOnDataModel(CharacterDataModel characterData)
    {
        Character character = new(characterData);
        RaceAggregate race = new(characterData.Race);
        Class @class = new(characterData.Class);
        BackpackAggregate backpack = new(characterData.Backpack);
        Level level = new(characterData.Level);
        BackgroundAggregate background = new(characterData.Background);

        return new CharacterAggregateRoot(character, race, @class, backpack, level, background);
    }

    public static CharacterAggregateRoot CreateCharacter(Guid id, string name, double height, double weight, int age,
        string appearanceDescription, string backgroundDescription, RaceDataModel raceDataModel,
        ClassDataModel classDataModel, BackgroundDataModel backgroundDataModel, CoinPurse coinPurse)
    {
        Character character = CreateCharacterValueObject(id, name, height, weight, age, appearanceDescription,
            backgroundDescription, raceDataModel.AbilityScoreIncrease
                .Select(x => x.AbilityScore), coinPurse);

        RaceAggregate race = new(raceDataModel);
        Class @class = new(classDataModel);
        BackpackAggregate backpack = new(Guid.NewGuid(), character.Id);
        Level level = new(Guid.NewGuid(), character.Id, 1, 0, 300);
        BackgroundAggregate background = new(backgroundDataModel);

        var aggregateRoot = new CharacterAggregateRoot(character, race, @class, backpack, level, background);

        return aggregateRoot;
    }

    private static Character CreateCharacterValueObject(Guid id, string name, double height, double weight, int age,
        string appearanceDescription, string backgroundDescription, IEnumerable<AbilityScoreValueObject> raceAbilityScoreIncrease,
        CoinPurse coinPurse)
    {
        Dictionary<EAbility, int> abilityScores = CreateDefaultAbilityScores();

        foreach (var abilityScore in raceAbilityScoreIncrease)
            abilityScores[abilityScore.AbilityScore] += abilityScore.Value;

        return new(id, name, height, weight, age, appearanceDescription, backgroundDescription, abilityScores,
            coinPurse);
    }

    private static Dictionary<EAbility, int> CreateDefaultAbilityScores()
    {
        return new()
        {
            { EAbility.Strength, 8 },
            { EAbility.Dexterity, 8 },
            { EAbility.Constitution, 8 },
            { EAbility.Intelligence, 8 },
            { EAbility.Wisdom, 8 },
            { EAbility.Charisma, 8 }
        };
    }
}