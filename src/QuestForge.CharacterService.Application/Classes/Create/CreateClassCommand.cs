using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Application.Classes.Create;

public class CreateClassCommand(string name, string description, int hitDie, List<EArmorProficiency> armorProficiencies,
        List<EWeaponProficiency> weaponProficiencies, List<EToolProficiency> toolProficiencies,
        List<EAbility> savingThrows, List<ESkillProficiency> skillsProficiencies)
    : Command
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
    public int HitDie { get; private set; } = hitDie;
    public List<EArmorProficiency> ArmorProficiencies { get; private set; } = armorProficiencies;
    public List<EWeaponProficiency> WeaponProficiencies { get; private set; } = weaponProficiencies;
    public List<EToolProficiency> ToolProficiencies { get; private set; } = toolProficiencies;
    public List<EAbility> SavingThrows { get; private set; } = savingThrows;
    public List<ESkillProficiency> SkillsProficiencies { get; private set; } = skillsProficiencies;
}