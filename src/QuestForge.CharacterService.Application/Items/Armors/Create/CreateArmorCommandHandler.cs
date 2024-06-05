using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Application.Items.Armors.Create;

public class CreateArmorCommandHandler(IRepository<ArmorDataModel> repository) : IHandler<CreateArmorCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(CreateArmorCommand command,
        CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.AddAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Armor created successfully!");
    }
}