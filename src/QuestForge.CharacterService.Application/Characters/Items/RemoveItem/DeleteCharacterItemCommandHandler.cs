using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Characters.Items.RemoveItem;

public class DeleteCharacterItemCommandHandler(IRepository<CharacterItemDataModel> repository)
    : IHandler<DeleteCharacterItemCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(DeleteCharacterItemCommand command,
        CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.DeleteAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new($"Item: '{command.ItemId}' deleted from character: '{command.CharacterId}' successfully!");
    }
}