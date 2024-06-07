using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Characters.Items.Create;

public class GiveCharacterItemCommandHandler(IRepository<CharacterItemDataModel> repository)
    : IHandler<GiveCharacterItemCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(GiveCharacterItemCommand command,
        CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.AddAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new($"Item of type: '{command.ItemId}' given to character: '{command.CharacterId}' successfully!");
    }
}