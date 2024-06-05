using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Classes.DataModels;
using QuestForge.CharacterService.Core.Classes.Enums;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Utils.Converters;

namespace QuestForge.CharacterService.Core.Classes.Entities;

public class Class : ValueObject
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int HitDie { get; private set; }

    [JsonConverter(typeof(EnumListToStringListConverter<EArmorProficiency>))]
    public List<EArmorProficiency> ArmorProficiencies { get; private set; }

    [JsonConverter(typeof(EnumListToStringListConverter<EWeaponProficiency>))]
    public List<EWeaponProficiency> WeaponProficiencies { get; private set; }

    [JsonConverter(typeof(EnumListToStringListConverter<EToolProficiency>))]
    public List<EToolProficiency> ToolProficiencies { get; private set; }

    [JsonConverter(typeof(EnumListToStringListConverter<EAbility>))]
    public List<EAbility> SavingThrows { get; private set; }

    [JsonConverter(typeof(EnumListToStringListConverter<ESkillProficiency>))]
    public List<ESkillProficiency> SkillsProficiencies { get; private set; }

    public Class(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as ClassDataModel;
        
        Id = parsedDataModel!.Id;
        Name = parsedDataModel.Name;
        Description = parsedDataModel.Description;
        HitDie = parsedDataModel.HitDie;
        ArmorProficiencies = parsedDataModel.ArmorProficiencies;
        WeaponProficiencies = parsedDataModel.WeaponProficiencies;
        ToolProficiencies = parsedDataModel.ToolProficiencies;
        SavingThrows = parsedDataModel.SavingThrows;
        SkillsProficiencies = parsedDataModel.SkillsProficiencies;
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
    
    public void UpdateHitDie(int? hitDie)
    {
        if (hitDie != null && !HitDie.Equals(hitDie))
            HitDie = hitDie.Value;
    }

    public void UpdateArmorProficiencies(List<EArmorProficiency> armorProficiencies)
    {
        if (armorProficiencies != null && armorProficiencies.Count != 0 && !ArmorProficiencies.Equals(armorProficiencies))
            ArmorProficiencies = armorProficiencies;
    }

    public void UpdateWeaponProficiencies(List<EWeaponProficiency> weaponProficiencies)
    {
        if (weaponProficiencies != null && weaponProficiencies.Count != 0 && !WeaponProficiencies.Equals(weaponProficiencies))
            WeaponProficiencies = weaponProficiencies;
    }

    public void UpdateToolProficiencies(List<EToolProficiency> toolProficiencies)
    {
        if (toolProficiencies != null && toolProficiencies.Count != 0 && !ToolProficiencies.Equals(toolProficiencies))
            ToolProficiencies = toolProficiencies;
    }

    public void UpdateSavingThrows(List<EAbility> savingThrows)
    {
        if (savingThrows != null && savingThrows.Count != 0 && !SavingThrows.Equals(savingThrows))
            SavingThrows = savingThrows;
    }

    public void UpdateSkillsProficiencies(List<ESkillProficiency> skillsProficiencies)
    {
        if (skillsProficiencies != null && skillsProficiencies.Count != 0 && !SkillsProficiencies.Equals(skillsProficiencies))
            SkillsProficiencies = skillsProficiencies;
    }
}