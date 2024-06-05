using QuestForge.CharacterService.Application.Common.Models;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Application.Items.Potions.Update;

public class UpdatePotionCommandHandler(IRepository<PotionDataModel> repository) : IHandler<UpdatePotionCommand, DatabaseOperationViewModel>
{
    public async Task<DatabaseOperationViewModel> Handle(UpdatePotionCommand command,
        CancellationToken cancellationToken)
    {
        await repository.UnitOfWork.StartAsync(cancellationToken);

        await repository.UpdateAsync(command, cancellationToken);

        await repository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        await repository.UnitOfWork.CommitAsync(cancellationToken);

        return new("Potion updated successfully!");
    }
}