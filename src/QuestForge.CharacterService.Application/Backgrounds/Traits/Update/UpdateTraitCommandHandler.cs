using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Backgrounds.Traits.Update;

public class UpdateTraitCommandHandler(IRepository<TraitDataModel> repository) : IHandler<UpdateTraitCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(UpdateTraitCommand command,
        CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.UpdateAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Trait updated successfully!");
    }
}