namespace QuestForge.CharacterService.Core.Common.Abstracts.Base;

public abstract class DeleteEntityBaseCommand : Command
{
    public Guid Id { get; set; }
}