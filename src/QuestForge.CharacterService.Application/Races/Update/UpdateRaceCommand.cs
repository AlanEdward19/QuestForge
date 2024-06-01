﻿using QuestForge.CharacterService.Core.Characters.Enums;
using QuestForge.CharacterService.Core.Common.Abstracts;

namespace QuestForge.CharacterService.Application.Races.Update;

public class UpdateRaceCommand(string? name, string? description, Dictionary<EAbilityScore, int>? abilityScoreIncrease) : Command
{
    public Guid Id { get; private set; }
    public string? Name { get; private set; } = name;
    public string? Description { get; private set; } = description;
    public Dictionary<EAbilityScore, int>? AbilityScoreIncrease { get; private set; } = abilityScoreIncrease;

    public void SetId(Guid id) => Id = id;
}