using QuestForge.CharacterService.Core.Classes.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Utils.Converters;
using System.Text.Json.Serialization;
using QuestForge.CharacterService.Core.Classes.Enums;

namespace QuestForge.CharacterService.Core.Characters.Aggregates;

public class Class : ValueObject
{
    [JsonIgnore]
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
}