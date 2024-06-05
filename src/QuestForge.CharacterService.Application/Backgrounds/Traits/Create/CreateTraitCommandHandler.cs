using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Backgrounds.Traits.Create;

public class CreateTraitCommandHandler(IRepository<TraitDataModel> repository) : IHandler<CreateTraitCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(CreateTraitCommand command, CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.AddAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Trait created successfully!");
    }
}