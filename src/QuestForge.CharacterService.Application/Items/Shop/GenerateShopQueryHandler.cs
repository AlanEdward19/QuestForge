using QuestForge.CharacterService.Application.Items.Common.List;
using QuestForge.CharacterService.Application.Items.Common.Utils;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Items.Entities;
using QuestForge.CharacterService.Core.Items.Enums;

namespace QuestForge.CharacterService.Application.Items.Shop;

public class GenerateShopQueryHandler(
    IRepository<ItemDataModel> itemRepository,
    IRepository<WeaponDataModel> weaponRepository,
    IRepository<PotionDataModel> potionRepository,
    IRepository<ArmorDataModel> armorRepository) : IHandler<GenerateShopQuery, IEnumerable<Item>>
{
    private static readonly Random random = new();

    public async Task<IEnumerable<Item>> Handle(GenerateShopQuery command, CancellationToken cancellationToken)
    {
        ListItemQuery query = new();
        List<Item> items = new(command.Size);
        if (command.Type != null)
        {
            List<Item> allItems = new(1000);
            foreach (var type in command.Type)
            {
                query.Type = type;
                
                allItems.AddRange(type switch
                {
                    EItemType.Armor => Mapper.MapDataModelsToEntities<Armor>(
                        await armorRepository.GetAllAsync(command, cancellationToken)),
                    EItemType.Potion => Mapper.MapDataModelsToEntities<Potion>(
                        await potionRepository.GetAllAsync(command, cancellationToken)),
                    EItemType.Weapon => Mapper.MapDataModelsToEntities<Weapon>(
                        await weaponRepository.GetAllAsync(command, cancellationToken)),
                    _ => Mapper.MapDataModelsToEntities<Item>(
                        await itemRepository.GetAllAsync(query, cancellationToken))
                });
            }

            var randomItems = allItems.OrderBy(x => random.Next()).Take(command.Size);
            items.AddRange(randomItems);
        }
        else
        {
            List<EItemType> itemTypes = new List<EItemType>
            {
                EItemType.Miscellaneous,
                EItemType.Tool,
                EItemType.EquipmentPacks,
                EItemType.FoodAndDrink
            };

            List<Item> allItems = new(1000);

            foreach (var itemType in itemTypes)
            {
                query.Type = itemType;
                allItems.AddRange(
                    Mapper.MapDataModelsToEntities<Item>(await itemRepository.GetAllAsync(query, cancellationToken)));
            }

            var randomItems = allItems.OrderBy(x => random.Next()).Take(command.Size);
            items.AddRange(randomItems);
        }

        return items.OrderBy(x => x.Type);
    }
}