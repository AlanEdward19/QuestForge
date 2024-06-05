using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Application.Races.Create;
using QuestForge.CharacterService.Application.Races.Delete;
using QuestForge.CharacterService.Application.Races.Get;
using QuestForge.CharacterService.Application.Races.Update;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.ValueObjects;
using QuestForge.CharacterService.Core.Races.Aggregates;
using QuestForge.CharacterService.Core.Races.DataModels;
using QuestForge.CharacterService.Core.Races.Entities;

namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class RaceRepository(IUnitOfWork unitOfWork, AppDbContext dbContext) : IRepository<RaceDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;

    public async Task<RaceDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        var parsedQuery = query as GetRaceQuery;

        return await dbContext.Races
            .FirstAsync(x => x.Id.Equals(parsedQuery!.Id), cancellationToken);
    }

    public Task<IEnumerable<RaceDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as CreateRaceCommand;
        Guid raceId = Guid.NewGuid();

        List<FeatureDataModel> featuresDataModel = await dbContext.Features
            .Where(x => parsedCommand.FeatureIds.Contains(x.Id))
            .ToListAsync(cancellationToken);

        RaceDataModel race = new(raceId, parsedCommand!.Name!, parsedCommand!.Description!, parsedCommand.Movement!.Value,
            AbilityScoreValueObject.BuildFromDictionary(parsedCommand.AbilityScoreIncrease!), featuresDataModel);

        await dbContext.Races.AddAsync(race, cancellationToken);
    }

    public async Task UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as UpdateRaceCommand;

        RaceDataModel raceDataModel =
            await dbContext.Races.FirstAsync(x => x.Id.Equals(parsedCommand!.Id), cancellationToken);

        RaceAggregateRoot race = new(raceDataModel);

        // validar caso lista venha vazia
        List<FeatureDataModel> featuresDataModel = await dbContext.Features
            .Where(x => parsedCommand.FeatureIds.Contains(x.Id))
            .ToListAsync(cancellationToken);

        List<Feature> features = featuresDataModel.Select(x => new Feature(x)).ToList();

        race.UpdateName(parsedCommand!.Name);
        race.UpdateDescription(parsedCommand.Description);
        race.UpdateAbilityScoreIncrease(parsedCommand.AbilityScoreIncrease);
        race.UpdateMovement(parsedCommand.Movement);
        race.UpdateFeatures(features);
        
        raceDataModel.UpdateBasedOnValueObject(race);

        dbContext.Races.Update(raceDataModel);
    }

    public async Task DeleteAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as DeleteRaceCommand;

        RaceDataModel race = await dbContext.Races.FirstAsync(x => x.Id.Equals(parsedCommand!.Id), cancellationToken);

        dbContext.Races.Remove(race);
    }
}