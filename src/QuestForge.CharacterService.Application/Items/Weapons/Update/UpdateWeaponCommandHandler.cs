using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Application.Items.Weapons.Update;

public class UpdateWeaponCommandHandler
    (IRepository<WeaponDataModel> repository) : IHandler<UpdateWeaponCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(UpdateWeaponCommand command,
        CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.UpdateAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Weapon updated successfully!");
    }
}