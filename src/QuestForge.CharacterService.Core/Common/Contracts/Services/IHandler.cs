namespace QuestForge.CharacterService.Core.Common.Contracts.Services;

public interface IHandler<in TCommand, TResult>
{ 
    public Task<TResult> Handle(TCommand command, CancellationToken cancellationToken);
}