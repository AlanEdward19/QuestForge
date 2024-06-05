using QuestForge.CharacterService.Application.Common.Features.Create;
using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Races.DataModels;

namespace QuestForge.CharacterService.Application.Common.Features.Delete;

public class DeleteFeatureCommandHandler
    (IRepository<FeatureDataModel> repository) : IHandler<DeleteFeatureCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(DeleteFeatureCommand command,
        CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.DeleteAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Feature deleted successfully!");
    }
}