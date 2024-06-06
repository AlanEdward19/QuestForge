using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Application.Classes.Create;
using QuestForge.CharacterService.Application.Classes.Delete;
using QuestForge.CharacterService.Application.Classes.Get;
using QuestForge.CharacterService.Application.Classes.Update;
using QuestForge.CharacterService.Core.Classes.DataModels;
using QuestForge.CharacterService.Core.Classes.Entities;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;

namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class ClassRepository(IUnitOfWork unitOfWork, AppDbContext dbContext) : IRepository<ClassDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;

    public async Task<ClassDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        var parsedQuery = query as GetClassQuery;

        return await dbContext.Classes
            .FirstAsync(x => x.Id.Equals(parsedQuery!.Id), cancellationToken);
    }

    public async Task<IEnumerable<ClassDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as CreateClassCommand;

        ClassDataModel @class = new(parsedCommand!.Name!, parsedCommand!.Description!,
            parsedCommand.HitDie!, parsedCommand.CoinDice, parsedCommand.CoinDiceAmount,
            parsedCommand.CoinDiceMultiplier, parsedCommand.ArmorProficiencies, parsedCommand.WeaponProficiencies,
            parsedCommand.ToolProficiencies,
            parsedCommand.SavingThrows, parsedCommand.SkillsProficiencies);

        await dbContext.Classes.AddAsync(@class, cancellationToken);
    }

    public async Task UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as UpdateClassCommand;

        ClassDataModel classDataModel =
            await dbContext.Classes.FirstAsync(x => x.Id.Equals(parsedCommand!.Id), cancellationToken);

        Class @class = new(classDataModel);

        @class.UpdateName(parsedCommand!.Name);
        @class.UpdateDescription(parsedCommand.Description);
        @class.UpdateHitDie(parsedCommand.HitDie);
        @class.UpdateWeaponProficiencies(parsedCommand.WeaponProficiencies);
        @class.UpdateArmorProficiencies(parsedCommand.ArmorProficiencies);
        @class.UpdateToolProficiencies(parsedCommand.ToolProficiencies);
        @class.UpdateSavingThrows(parsedCommand.SavingThrows);
        @class.UpdateSkillsProficiencies(parsedCommand.SkillsProficiencies);
        @class.UpdateCoinDice(parsedCommand.CoinDice);
        @class.UpdateCoinDiceAmount(parsedCommand.CoinDiceAmount);
        @class.UpdateCoinDiceMultiplier(parsedCommand.CoinDiceMultiplier);

        classDataModel.UpdateBasedOnValueObject(@class);

        dbContext.Classes.Update(classDataModel);
    }

    public async Task DeleteAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as DeleteClassCommand;

        ClassDataModel @class =
            await dbContext.Classes.FirstAsync(x => x.Id.Equals(parsedCommand!.Id), cancellationToken);

        dbContext.Classes.Remove(@class);
    }
}