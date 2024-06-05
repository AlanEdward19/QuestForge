using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Classes.DataModels;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Classes.Delete;

public class DeleteClassCommandHandler(IRepository<ClassDataModel> repository) : IHandler<DeleteClassCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(DeleteClassCommand command, CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.DeleteAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Class deleted successfully!");
    }
}