using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Application.Items.Armors.Create;
using QuestForge.CharacterService.Application.Items.Armors.Update;
using QuestForge.CharacterService.Application.Items.Common.Get;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Items.Entities;

namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class ArmorRepository(IUnitOfWork unitOfWork, AppDbContext dbContext) : IRepository<ArmorDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;
    public async Task<ArmorDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        var parsedQuery = query as GetItemQuery;

        return await dbContext.Armors
            .AsNoTracking()
            .AsSplitQuery()
            .FirstAsync(x => x.Id.Equals(parsedQuery!.Id), cancellationToken);
    }

    public async Task<IEnumerable<ArmorDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
    {
        return await dbContext.Armors
            .AsNoTracking()
            .AsSplitQuery()
            .ToListAsync(cancellationToken);
    }

    public async Task AddAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as CreateArmorCommand;

        var armorDataModel = new ArmorDataModel(parsedCommand.ArmorType, parsedCommand.ArmorClass,
            parsedCommand.Modifier, parsedCommand.MaxModifier, parsedCommand.MinStrength,
            parsedCommand.StealthDisadvantage, parsedCommand.Name, parsedCommand.Description, parsedCommand.Value,
            parsedCommand.CurrencyType, parsedCommand.Weight);

        await dbContext.Armors.AddAsync(armorDataModel, cancellationToken);
    }

    public async Task UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as UpdateArmorCommand;

        var armorDataModel = await dbContext.Armors
            .FirstAsync(x => x.Id.Equals(parsedCommand!.Id), cancellationToken);

        Armor armor = new(armorDataModel);

        armor.UpdateName(parsedCommand.Name);
        armor.UpdateDescription(parsedCommand.Description);
        armor.UpdateArmorClass(parsedCommand.ArmorClass);
        armor.UpdateArmorType(parsedCommand.ArmorType);
        armor.UpdateModifier(parsedCommand.Modifier);
        armor.UpdateMaxModifier(parsedCommand.MaxModifier);
        armor.UpdateMinStrength(parsedCommand.MinStrength);
        armor.UpdateStealthDisadvantage(parsedCommand.StealthDisadvantage);
        armor.UpdateValue(parsedCommand.Value);
        armor.UpdateCurrencyType(parsedCommand.CurrencyType);
        armor.UpdateWeight(parsedCommand.Weight);

        armorDataModel.UpdateBasedOnValueObject(armor);

        dbContext.Armors.Update(armorDataModel);
    }

    public async Task DeleteAsync(Command command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}