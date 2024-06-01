using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Application.Races.Create;
using QuestForge.CharacterService.Application.Races.Delete;
using QuestForge.CharacterService.Application.Races.Get;
using QuestForge.CharacterService.Application.Races.Update;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Common.ValueObjects;
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

        RaceDataModel race = new(raceId, parsedCommand!.Name!, parsedCommand!.Description!,
            AbilityScoreValueObject.BuildFromDictionary(parsedCommand.AbilityScoreIncrease!));

        await dbContext.Races.AddAsync(race, cancellationToken);
    }

    public async Task UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as UpdateRaceCommand;

        RaceDataModel raceDataModel =
            await dbContext.Races.FirstAsync(x => x.Id.Equals(parsedCommand!.Id), cancellationToken);

        Race race = new(raceDataModel);
        
        race.UpdateName(parsedCommand!.Name);
        race.UpdateDescription(parsedCommand.Description);
        race.UpdateAbilityScoreIncrease(parsedCommand.AbilityScoreIncrease);
        
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