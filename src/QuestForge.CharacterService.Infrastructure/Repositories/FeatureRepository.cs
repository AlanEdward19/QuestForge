using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Application.Common.Features.Create;
using QuestForge.CharacterService.Application.Common.Features.Delete;
using QuestForge.CharacterService.Application.Common.Features.Get;
using QuestForge.CharacterService.Application.Common.Features.Update;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Entities;
using QuestForge.CharacterService.Core.Races.DataModels;

namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class FeatureRepository(IUnitOfWork unitOfWork, AppDbContext dbContext) : IRepository<FeatureDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;
    public async Task<FeatureDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        var parsedQuery = query as GetFeatureQuery;

        return await dbContext.Features
            .FirstAsync(x => x.Id.Equals(parsedQuery!.Id), cancellationToken);
    }

    public async Task<IEnumerable<FeatureDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as CreateFeatureCommand;

        FeatureDataModel feature = new(parsedCommand!.Name!, parsedCommand!.Description!);

        await dbContext.Features.AddAsync(feature, cancellationToken);
    }

    public async Task UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as UpdateFeatureCommand;

        FeatureDataModel featureDataModel =
            await dbContext.Features.FirstAsync(x => x.Id.Equals(parsedCommand!.Id), cancellationToken);

        Feature feature = new(featureDataModel);

        feature.UpdateName(parsedCommand!.Name);
        feature.UpdateDescription(parsedCommand.Description);

        featureDataModel.UpdateBasedOnValueObject(feature);

        dbContext.Features.Update(featureDataModel);
    }

    public async Task DeleteAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as DeleteFeatureCommand;

        FeatureDataModel feature =
            await dbContext.Features.FirstAsync(x => x.Id.Equals(parsedCommand!.Id), cancellationToken);

        dbContext.Features.Remove(feature);
    }
}