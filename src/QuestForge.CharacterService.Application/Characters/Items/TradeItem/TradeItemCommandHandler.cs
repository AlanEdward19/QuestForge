using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Characters.Items.TradeItem;

public class TradeItemCommandHandler(IRepository<CharacterItemDataModel> repository)
    : IHandler<TradeItemCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(TradeItemCommand command,
        CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.UpdateAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new($"Item: '{command.ItemId}' from character: '{command.FromCharacterId}' was given to character: '{command.ToCharacterId}' successfully!");
    }
}