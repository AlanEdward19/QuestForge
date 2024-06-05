using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Application.Backgrounds.Create;

public class CreateBackgroundCommand(string name, string description, List<ESkillProficiency> proficiencies, int initialWealth, List<Guid> itemIds) : Command
{
    public string Name { get; private set; } = name;
    public string Description { get; private set; } = description;
    public int InitialWealth { get; private set; } = initialWealth;
    public List<ESkillProficiency> Proficiencies { get; private set; } = proficiencies;
    public List<Guid> ItemIds { get; private set; } = itemIds;
}