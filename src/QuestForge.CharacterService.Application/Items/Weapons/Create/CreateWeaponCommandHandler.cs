using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Application.Items.Weapons.Create;

public class CreateWeaponCommandHandler(IRepository<WeaponDataModel> repository) : IHandler<CreateWeaponCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(CreateWeaponCommand command,
        CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.AddAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Weapon created successfully!");
    }
}