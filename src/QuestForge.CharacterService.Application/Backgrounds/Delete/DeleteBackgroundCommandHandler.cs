using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Backgrounds.Delete;

public class DeleteBackgroundCommandHandler(IRepository<BackgroundDataModel> repository) : IHandler<DeleteBackgroundCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(DeleteBackgroundCommand command,
        CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.DeleteAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Background deleted successfully!");
    }
}