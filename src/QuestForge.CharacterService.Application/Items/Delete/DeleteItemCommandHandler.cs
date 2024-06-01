using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Application.Items.Delete;

public class DeleteItemCommandHandler(IRepository<ItemDataModel> repository) : IHandler<DeleteItemCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(DeleteItemCommand command, CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.DeleteAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Item deleted successfully!");
    }
}