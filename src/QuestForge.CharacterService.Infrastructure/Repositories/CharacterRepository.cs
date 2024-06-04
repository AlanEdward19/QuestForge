using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Application.Characters.Create;
using QuestForge.CharacterService.Application.Characters.Delete;
using QuestForge.CharacterService.Application.Characters.Get;
using QuestForge.CharacterService.Core.Characters.Aggregates;
using QuestForge.CharacterService.Core.Characters.Entities;
using QuestForge.CharacterService.Core.Characters.Services;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class CharacterRepository(IUnitOfWork unitOfWork, AppDbContext dbContext) : IRepository<CharacterDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;

    public Task<CharacterDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        var parsedQuery = query as GetCharacterQuery;

        return dbContext.Characters
            .AsNoTracking()
            .AsSplitQuery()
            .Include(x => x.Backpack)
            .ThenInclude(x => x.Items)
            .ThenInclude(x => x.Item)
            .Include(x => x.Class)
            .Include(x => x.Race)
            .ThenInclude(x => x.AbilityScoreIncrease)
            .ThenInclude(x => x.AbilityScore)
            .Include(x => x.Race)
            .ThenInclude(x => x.Features)
            .Include(x => x.Level)
            .Include(x => x.AbilityScores)
            .ThenInclude(x => x.AbilityScore)
            .FirstAsync(x => x.Id.Equals(parsedQuery!.Id), cancellationToken);
    }

    public Task<IEnumerable<CharacterDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as CreateCharacterCommand;
        Guid characterId = Guid.NewGuid();

        RaceDataModel race =
            await dbContext.Races
                .AsSplitQuery()
                .AsNoTracking()
                .Include(x => x.AbilityScoreIncrease)
                .ThenInclude(x => x.AbilityScore)
                .Include(x => x.Features)
                .FirstAsync(x => x.Id.Equals(parsedCommand!.RaceId), cancellationToken);

        ClassDataModel @class =
            await dbContext.Classes
                .AsSplitQuery()
                .AsNoTracking()
                .FirstAsync(x => x.Id.Equals(parsedCommand!.ClassId), cancellationToken);

        CharacterAggregateRoot aggregateRoot = CharacterCreationService.CreateCharacter(characterId,
            parsedCommand!.Name,
            parsedCommand.Height, parsedCommand.Weight, parsedCommand.Age, parsedCommand.AppearanceDescription,
            parsedCommand.BackgroundDescription, race, @class);

        CharacterDataModel characterDataModel = aggregateRoot.BuildClassDataModel();
        BackpackDataModel backpackDataModel = aggregateRoot.Backpack.BuildClassDataModel();
        LevelDataModel levelDataModel = aggregateRoot.Level.BuildClassDataModel();

        await dbContext.Backpacks.AddAsync(backpackDataModel, cancellationToken);
        await dbContext.Levels.AddAsync(levelDataModel, cancellationToken);
        await dbContext.Characters.AddAsync(characterDataModel, cancellationToken);
    }

    public Task UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as DeleteCharacterCommand;

        CharacterDataModel characterDataModel =
            await dbContext.Characters.FirstAsync(x => x.Id.Equals(parsedCommand!.Id), cancellationToken);

        dbContext.Characters.Remove(characterDataModel);
    }
}