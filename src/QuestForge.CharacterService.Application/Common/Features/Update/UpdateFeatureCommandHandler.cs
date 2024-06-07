using QuestForge.CharacterService.Application.Common.Features.Create;
using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Races.DataModels;

namespace QuestForge.CharacterService.Application.Common.Features.Update;

public class UpdateFeatureCommandHandler
    (IRepository<FeatureDataModel> repository) : IHandler<UpdateFeatureCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(UpdateFeatureCommand command,
        CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.UpdateAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Feature updated successfully!");
    }
}