using QuestForge.CharacterService.Core.Characters.Aggregates;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Characters.Entities;
using QuestForge.CharacterService.Core.Classes.DataModels;
using QuestForge.CharacterService.Core.Classes.Entities;
using QuestForge.CharacterService.Core.Common.Entities;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Common.ValueObjects;
using QuestForge.CharacterService.Core.Races.DataModels;
using QuestForge.CharacterService.Core.Races.Entities;

namespace QuestForge.CharacterService.Core.Characters.Services;

public static class CharacterCreationService
{
    public static CharacterAggregateRoot CreateCharacterBasedOnDataModel(CharacterDataModel characterData)
    {
        Character character = new(characterData);
        Race race = new(characterData.Race);
        Class @class = new(characterData.Class);
        Backpack backpack = new(Guid.NewGuid(), character.Id);
        Level level = new(Guid.NewGuid(), character.Id, 1, 0, 300);

        return new CharacterAggregateRoot(character, race, @class, backpack, level);
    }

    public static CharacterAggregateRoot CreateCharacter(Guid id, string name, double height, double weight, int age,
        string appearanceDescription, string backgroundDescription, RaceDataModel raceDataModel,
        ClassDataModel classDataModel)
    {
        Character character = CreateCharacterValueObject(id, name, height, weight, age, appearanceDescription,
            backgroundDescription, raceDataModel.AbilityScoreIncrease
                .Select(x => x.AbilityScore));

        Race race = new(raceDataModel);
        Class @class = new(classDataModel);
        Backpack backpack = new(Guid.NewGuid(), character.Id);
        Level level = new(Guid.NewGuid(), character.Id, 1, 0, 300);

        var aggregateRoot = new CharacterAggregateRoot(character, race, @class, backpack, level);

        return aggregateRoot;
    }

    private static Character CreateCharacterValueObject(Guid id, string name, double height, double weight, int age,
        string appearanceDescription, string backgroundDescription,
        IEnumerable<AbilityScoreValueObject> raceAbilityScoreIncrease)
    {
        Dictionary<EAbility, int> abilityScores = CreateDefaultAbilityScores();

        foreach (var abilityScore in raceAbilityScoreIncrease)
            abilityScores[abilityScore.AbilityScore] += abilityScore.Value;

        return new(id, name, height, weight, age, appearanceDescription, backgroundDescription, abilityScores);
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