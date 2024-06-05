using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Races.DataModels;

namespace QuestForge.CharacterService.Application.Races.Create;

public class CreateRaceCommandHandler(IRepository<RaceDataModel> repository):IHandler<CreateRaceCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(CreateRaceCommand command, CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.AddAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Race created successfully!");
    }
}