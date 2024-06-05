using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Application.Backgrounds.Create;
using QuestForge.CharacterService.Application.Backgrounds.Delete;
using QuestForge.CharacterService.Application.Backgrounds.Get;
using QuestForge.CharacterService.Application.Backgrounds.Update;
using QuestForge.CharacterService.Core.Backgrounds.Aggregates;
using QuestForge.CharacterService.Core.Backgrounds.DataModels;
using QuestForge.CharacterService.Core.Backgrounds.Entities;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Items.Entities;

namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class BackgroundRepository(IUnitOfWork unitOfWork, AppDbContext dbContext) : IRepository<BackgroundDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;
    public async Task<BackgroundDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        var parsedQuery = query as GetBackgroundQuery;

        return await dbContext.Backgrounds
            .AsNoTracking()
            .AsSplitQuery()
            .Include(b => b.Traits)
            .Include(x => x.Items)
            .FirstOrDefaultAsync(b => b.Id == parsedQuery.Id, cancellationToken);
    }

    public async Task<IEnumerable<BackgroundDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as CreateBackgroundCommand;

        List<ItemDataModel> itemDataModels = await dbContext.Items
            .Where(i => parsedCommand.ItemIds.Contains(i.Id))
            .ToListAsync(cancellationToken);

        BackgroundDataModel backgroundDataModel = new(parsedCommand.Name, parsedCommand.Description,
            parsedCommand.Proficiencies, parsedCommand.InitialWealth, itemDataModels);

        await dbContext.Backgrounds.AddAsync(backgroundDataModel, cancellationToken);
    }

    public async Task UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as UpdateBackgroundCommand;

        BackgroundDataModel backgroundDataModel = await dbContext.Backgrounds
            .Include(b => b.Traits)
            .Include(x => x.Items)
            .FirstOrDefaultAsync(b => b.Id == parsedCommand.Id, cancellationToken);

        List<Item>? items = null;
        List<Trait>? traits = null;

        if (parsedCommand.ItemIds != null && parsedCommand.ItemIds.Any())
            items = await dbContext.Items
                .Where(i => parsedCommand.ItemIds.Contains(i.Id))
                .Select(x => new Item(x))
                .ToListAsync(cancellationToken);

        if (parsedCommand.TraitIds != null && parsedCommand.TraitIds.Any())
            traits = await dbContext.Traits
                .Where(t => parsedCommand.TraitIds.Contains(t.Id))
                .Select(x => new Trait(x))
                .ToListAsync(cancellationToken);

        BackgroundAggregateRoot background = new(backgroundDataModel);

        background.UpdateName(parsedCommand.Name);
        background.UpdateDescription(parsedCommand.Description);
        background.UpdateProficiencies(parsedCommand.Proficiencies);
        background.UpdateItems(items);
        background.UpdateTraits(traits);
        background.UpdateInitialWealth(parsedCommand.InitialWealth);

        backgroundDataModel.UpdateBasedOnValueObject(background);

        dbContext.Backgrounds.Update(backgroundDataModel);
    }

    public async Task DeleteAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as DeleteBackgroundCommand;

        BackgroundDataModel backgroundDataModel = await dbContext.Backgrounds
            .FirstOrDefaultAsync(b => b.Id == parsedCommand.Id, cancellationToken);

        dbContext.Backgrounds.Remove(backgroundDataModel);
    }
}