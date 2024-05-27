namespace QuestForge.CharacterService.Core.Commons.Contracts.Services;

public interface IHandler<in TCommand, TResult>
{ 
    public Task<TResult> Handle(TCommand command, CancellationToken cancellationToken);
}