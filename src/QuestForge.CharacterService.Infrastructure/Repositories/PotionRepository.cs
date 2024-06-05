using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Application.Items.Common.Get;
using QuestForge.CharacterService.Application.Items.Potions.Create;
using QuestForge.CharacterService.Application.Items.Potions.Update;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Common.Entities;

namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class PotionRepository(IUnitOfWork unitOfWork, AppDbContext dbContext) : IRepository<PotionDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;
    public async Task<PotionDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        var parsedQuery = query as GetItemQuery;

        return await dbContext.Potions
            .AsNoTracking()
            .AsSplitQuery()
            .FirstAsync(x => x.Id.Equals(parsedQuery!.Id), cancellationToken);
    }

    public async Task<IEnumerable<PotionDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
    {
        return await dbContext.Potions
            .AsNoTracking()
            .AsSplitQuery()
            .ToListAsync(cancellationToken);
    }

    public async Task AddAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as CreatePotionCommand;

        var potionDataModel = new PotionDataModel(parsedCommand.Dice, parsedCommand.DiceCount, parsedCommand.Bonus,
            parsedCommand.Effect, parsedCommand.Name, parsedCommand.Description, parsedCommand.Value,
            parsedCommand.CurrencyType, parsedCommand.Weight);

        await dbContext.Potions.AddAsync(potionDataModel, cancellationToken);
    }

    public async Task UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as UpdatePotionCommand;

        var potionDataModel = await dbContext.Potions
            .FirstAsync(x => x.Id.Equals(parsedCommand!.Id), cancellationToken);

        Potion potion = new(potionDataModel);

        potion.UpdateName(parsedCommand.Name);
        potion.UpdateDescription(parsedCommand.Description);
        potion.UpdateDice(parsedCommand.Dice);
        potion.UpdateDiceCount(parsedCommand.DiceCount);
        potion.UpdateBonus(parsedCommand.Bonus);
        potion.UpdateEffect(parsedCommand.Effect);
        potion.UpdateValue(parsedCommand.Value);
        potion.UpdateCurrencyType(parsedCommand.CurrencyType);
        potion.UpdateWeight(parsedCommand.Weight);

        potionDataModel.UpdateBasedOnValueObject(potion);

        dbContext.Potions.Update(potionDataModel);
    }

    public async Task DeleteAsync(Command command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}