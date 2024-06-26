﻿using QuestForge.CharacterService.Core.Classes.Entities;
using QuestForge.CharacterService.Core.Classes.Enums;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Core.Classes.DataModels;

public class ClassDataModel : BaseDataModel
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int HitDie { get; private set; }
    public int CoinDice { get; private set; }
    public int CoinDiceAmount { get; private set; }
    public int CoinDiceMultiplier { get; private set; }
    public virtual List<EArmorProficiency> ArmorProficiencies { get; private set; }
    public virtual List<EWeaponProficiency> WeaponProficiencies { get; private set; }
    public virtual List<EToolProficiency> ToolProficiencies { get; private set; }
    public virtual List<EAbility> SavingThrows { get; private set; }
    public virtual List<ESkillProficiency> SkillsProficiencies { get; private set; }

    public ClassDataModel() { }

    public ClassDataModel(string name, string description, int hitDie, int coinDice, int coinDiceAmount,
        int coinDiceMultiplier, List<EArmorProficiency> armorProficiencies,
        List<EWeaponProficiency> weaponProficiencies,
        List<EToolProficiency> toolProficiencies, List<EAbility> savingThrows,
        List<ESkillProficiency> skillsProficiencies) : base(Guid.NewGuid())
    {
        Name = name;
        Description = description;
        HitDie = hitDie;
        CoinDice = coinDice;
        CoinDiceAmount = coinDiceAmount;
        CoinDiceMultiplier = coinDiceMultiplier;
        ArmorProficiencies = armorProficiencies;
        WeaponProficiencies = weaponProficiencies;
        ToolProficiencies = toolProficiencies;
        SavingThrows = savingThrows;
        SkillsProficiencies = skillsProficiencies;
    }

    public override void UpdateBasedOnValueObject(ValueObject valueObject)
    {
        var parsedValueObject = valueObject as Class;

        Name = parsedValueObject!.Name;
        Description = parsedValueObject.Description;
        HitDie = parsedValueObject.HitDie;
        CoinDice = parsedValueObject.CoinDice;
        CoinDiceAmount = parsedValueObject.CoinDiceAmount;
        CoinDiceMultiplier = parsedValueObject.CoinDiceMultiplier;
        ArmorProficiencies = parsedValueObject.ArmorProficiencies;
        WeaponProficiencies = parsedValueObject.WeaponProficiencies;
        ToolProficiencies = parsedValueObject.ToolProficiencies;
        SavingThrows = parsedValueObject.SavingThrows;
        SkillsProficiencies = parsedValueObject.SkillsProficiencies;

        base.UpdateBasedOnValueObject(valueObject);
    }
}