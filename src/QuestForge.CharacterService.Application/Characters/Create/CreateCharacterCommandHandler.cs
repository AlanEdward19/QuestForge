using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Characters.Create;

public class CreateCharacterCommandHandler(IRepository<CharacterDataModel> repository) : IHandler<CreateCharacterCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(CreateCharacterCommand command, CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.AddAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Character created successfully!");
    }
}