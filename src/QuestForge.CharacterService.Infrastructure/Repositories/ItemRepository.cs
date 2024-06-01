using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Application.Items.Create;
using QuestForge.CharacterService.Application.Items.Delete;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.DataModels;

namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class ItemRepository(IUnitOfWork unitOfWork, AppDbContext dbContext) : IRepository<ItemDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;
    
    public Task<ItemDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ItemDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as CreateItemCommand;

        ItemDataModel item = new(parsedCommand!.Name, parsedCommand.Description, parsedCommand.Type, parsedCommand.Value,
            parsedCommand.CurrencyType, parsedCommand.Weight);

        await dbContext.Items.AddAsync(item, cancellationToken);
    }

    public Task UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as DeleteItemCommand;
        
        ItemDataModel itemDataModel =
            await dbContext.Items.FirstAsync(x => x.Id.Equals(parsedCommand!.Id), cancellationToken);
        
        dbContext.Items.Remove(itemDataModel);
    }
}