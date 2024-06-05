using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Backgrounds.Traits.Delete;

public class DeleteTraitCommandHandler(IRepository<TraitDataModel> repository) : IHandler<DeleteTraitCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(DeleteTraitCommand command, CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.DeleteAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Trait deleted successfully!");
    }
}