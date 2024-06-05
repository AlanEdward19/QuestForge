using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Application.Backgrounds.Traits.Create;
using QuestForge.CharacterService.Application.Backgrounds.Traits.Delete;
using QuestForge.CharacterService.Application.Backgrounds.Traits.Get;
using QuestForge.CharacterService.Application.Backgrounds.Traits.Update;
using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Backgrounds.Entities;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;

namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class TraitRepository(IUnitOfWork unitOfWork, AppDbContext dbContext) : IRepository<TraitDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;
    public async Task<TraitDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        var parsedQuery = query as GetTraitQuery;

        return await dbContext.Traits
            .AsNoTracking()
            .AsSplitQuery()
            .FirstOrDefaultAsync(t => t.Id == parsedQuery.Id, cancellationToken);
    }

    public async Task<IEnumerable<TraitDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as CreateTraitCommand;

        TraitDataModel traitDataModel = new(parsedCommand.BackgroundId, parsedCommand.Type, parsedCommand.Description);

        await dbContext.Traits.AddAsync(traitDataModel, cancellationToken);
    }

    public async Task UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as UpdateTraitCommand;

        TraitDataModel traitDataModel = await dbContext.Traits
            .FirstOrDefaultAsync(t => t.Id == parsedCommand.Id, cancellationToken);

        Trait trait = new(traitDataModel);

        trait.UpdateDescription(parsedCommand.Description);
        trait.UpdateBackgroundId(parsedCommand.BackgroundId);
        trait.UpdateType(parsedCommand.Type);

        traitDataModel.UpdateBasedOnValueObject(trait);

        dbContext.Traits.Update(traitDataModel);
    }

    public async Task DeleteAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as DeleteTraitCommand;

        TraitDataModel traitDataModel = await dbContext.Traits
            .FirstOrDefaultAsync(t => t.Id == parsedCommand.Id, cancellationToken);

        dbContext.Traits.Remove(traitDataModel);
    }
}