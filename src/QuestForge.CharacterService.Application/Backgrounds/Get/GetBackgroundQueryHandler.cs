using QuestForge.CharacterService.Core.Backgrounds.Aggregates;
using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;

namespace QuestForge.CharacterService.Application.Backgrounds.Get;

public class GetBackgroundQueryHandler(IRepository<BackgroundDataModel> repository) : IHandler<GetBackgroundQuery, BackgroundAggregateRoot>
{
    public async Task<BackgroundAggregateRoot> Handle(GetBackgroundQuery command, CancellationToken cancellationToken)
    {
        BackgroundDataModel backgroundDataModel = await repository.GetByIdAsync(command, cancellationToken);

        return new BackgroundAggregateRoot(backgroundDataModel);
    }
}