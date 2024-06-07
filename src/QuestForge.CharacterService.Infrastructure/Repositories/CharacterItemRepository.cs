using Microsoft.EntityFrameworkCore;
using QuestForge.CharacterService.Application.Characters.Items.AddItem;
using QuestForge.CharacterService.Application.Characters.Items.RemoveItem;
using QuestForge.CharacterService.Application.Characters.Items.TradeItem;
using QuestForge.CharacterService.Core.Characters.Aggregates.Backpack;
using QuestForge.CharacterService.Core.Characters.DataModels;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Items.Entities;

namespace QuestForge.CharacterService.Infrastructure.Repositories;

public class CharacterItemRepository(IUnitOfWork unitOfWork, AppDbContext dbContext)
    : IRepository<CharacterItemDataModel>
{
    public IUnitOfWork UnitOfWork { get; } = unitOfWork;

    public async Task<CharacterItemDataModel> GetByIdAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<CharacterItemDataModel>> GetAllAsync(Query query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as AddCharacterItemCommand;

        CharacterDataModel characterDataModel =
            await dbContext.Characters
                .Include(x => x.Backpack)
                .ThenInclude(x => x.Items)
                .ThenInclude(x => x.Item)
                .FirstAsync(x => x.Id == parsedCommand.CharacterId, cancellationToken);

        ItemDataModel itemDataModel = await dbContext.Items
            .AsNoTracking()
            .FirstAsync(x => x.Id == parsedCommand.ItemId, cancellationToken);

        Item item = new(itemDataModel);
        BackpackAggregate backpack = new(characterDataModel.Backpack);
        
        backpack.AddItem(item, parsedCommand.Quantity);
        
        characterDataModel.Backpack.UpdateBasedOnValueObject(backpack);

        await dbContext.CharacterItems.AddRangeAsync(characterDataModel.Backpack.Items, cancellationToken);
    }

    public async Task UpdateAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as TradeItemCommand;
        
        DeleteCharacterItemCommand deleteCharacterItemCommand =
            new(parsedCommand.FromCharacterId, parsedCommand.ItemId, parsedCommand.Quantity);

        await DeleteAsync(deleteCharacterItemCommand, cancellationToken);
        
        AddCharacterItemCommand addCharacterItemCommand =
            new(parsedCommand.ToCharacterId, parsedCommand.ItemId, parsedCommand.Quantity);
        await AddAsync(addCharacterItemCommand, cancellationToken);
    }

    public async Task DeleteAsync(Command command, CancellationToken cancellationToken)
    {
        var parsedCommand = command as DeleteCharacterItemCommand;

        CharacterDataModel characterDataModel =
            await dbContext.Characters
                .Include(x => x.Backpack)
                .ThenInclude(x => x.Items)
                .ThenInclude(x => x.Item)
                .FirstAsync(x => x.Id == parsedCommand.CharacterId, cancellationToken);

        var item = characterDataModel.Backpack.Items.First(x => x.ItemId.Equals(parsedCommand.ItemId));
        
        if(parsedCommand.Quantity == item.Quantity)
            dbContext.CharacterItems.Remove(item);
        else
        {
            CharacterItem characterItem = new(item);
            characterItem.RemoveQuantity(parsedCommand.Quantity);
            
            item.UpdateBasedOnValueObject(characterItem);
            
            dbContext.CharacterItems.Update(item);
        }
    }
}