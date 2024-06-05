using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Application.Items.Common.Get;
using QuestForge.CharacterService.Application.Items.Weapons.Create;
using QuestForge.CharacterService.Application.Items.Weapons.Update;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Items.Entities;

namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class WeaponRepository(IUnitOfWork unitOfWork, AppDbContext dbContext) : IRepository<WeaponDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;
    public async Task<WeaponDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        var parsedQuery = query as GetItemQuery;

        return await dbContext.Weapons
            .AsNoTracking()
            .AsSplitQuery()
            .FirstAsync(x => x.Id.Equals(parsedQuery!.Id), cancellationToken);
    }

    public async Task<IEnumerable<WeaponDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
    {
        return await dbContext.Weapons
            .AsNoTracking()
            .AsSplitQuery()
            .ToListAsync(cancellationToken);
    }

    public async Task AddAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as CreateWeaponCommand;

        var weapon = new WeaponDataModel(
            parsedCommand!.Dice,
            parsedCommand.DamageType,
            parsedCommand.DiceCount,
            parsedCommand.Name,
            parsedCommand.Description,
            parsedCommand.Value,
            parsedCommand.CurrencyType,
            parsedCommand.Weight);

        await dbContext.Weapons.AddAsync(weapon, cancellationToken);
    }

    public async Task UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as UpdateWeaponCommand;

        var weaponDataModel = await dbContext.Weapons
            .FirstAsync(x => x.Id.Equals(parsedCommand!.Id), cancellationToken);

        Weapon weapon = new(weaponDataModel);

        weapon.UpdateName(parsedCommand.Name);
        weapon.UpdateDescription(parsedCommand.Description);
        weapon.UpdateDice(parsedCommand.Dice);
        weapon.UpdateDamageType(parsedCommand.DamageType);
        weapon.UpdateDiceCount(parsedCommand.DiceCount);
        weapon.UpdateValue(parsedCommand.Value);
        weapon.UpdateCurrencyType(parsedCommand.CurrencyType);
        weapon.UpdateWeight(parsedCommand.Weight);

        weaponDataModel.UpdateBasedOnValueObject(weapon);

        dbContext.Weapons.Update(weaponDataModel);
    }

    public async Task DeleteAsync(Command command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}