using QuestForge.CharacterService.Application.Items.Common.Get;
using QuestForge.CharacterService.Core.Common.Abstracts;
using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Common.Entities;
using QuestForge.CharacterService.Core.Common.Enums;

namespace QuestForge.CharacterService.Application.Items.Common.List;

public class ListItemQueryHandler(IRepository<ItemDataModel> itemRepository,
        IRepository<WeaponDataModel> weaponRepository, IRepository<PotionDataModel> potionRepository,
        IRepository<ArmorDataModel> armorRepository)
    : IHandler<ListItemQuery, IEnumerable<Item>>
{
    public async Task<IEnumerable<Item>> Handle(ListItemQuery command, CancellationToken cancellationToken) => command.Type switch
    {
        EItemType.Weapon => await MapDataModelToWeapon(command, cancellationToken),
        EItemType.Armor => await MapDataModelToArmor(command, cancellationToken),
        EItemType.Potion => await MapDataModelToPotion(command, cancellationToken),
        _ => await MapDataModelToItem(command, cancellationToken)
    };

    private async Task<IEnumerable<Item>> MapDataModelToWeapon(ListItemQuery query, CancellationToken cancellationToken)
    {
        var weaponDataModels = await weaponRepository.GetAllAsync(query, cancellationToken);

        return weaponDataModels.Select(weaponDataModel => new Weapon(weaponDataModel.Dice, weaponDataModel.DamageType,
            weaponDataModel.DiceCount, weaponDataModel.Id, weaponDataModel.Name, weaponDataModel.Description,
            weaponDataModel.Type, weaponDataModel.CurrencyType, weaponDataModel.Value, weaponDataModel.Weight));
    }

    private async Task<IEnumerable<Item>> MapDataModelToArmor(ListItemQuery query, CancellationToken cancellationToken)
    {
        var armorDataModels = await armorRepository.GetAllAsync(query, cancellationToken);

        return armorDataModels.Select(armorDataModel => new Armor(armorDataModel.ArmorClass, armorDataModel.ArmorType,
            armorDataModel.Modifier, armorDataModel.MaxModifier, armorDataModel.MinStrength,
            armorDataModel.StealthDisadvantage, armorDataModel.Id, armorDataModel.Name, armorDataModel.Description,
            armorDataModel.Type, armorDataModel.CurrencyType, armorDataModel.Value, armorDataModel.Weight));
    }
    private async Task<IEnumerable<Item>> MapDataModelToPotion(ListItemQuery query, CancellationToken cancellationToken)
    {
        var potionDataModels = await potionRepository.GetAllAsync(query, cancellationToken);

        return potionDataModels.Select(potionDataModel => new Potion(potionDataModel.Dice, potionDataModel.DiceCount,
            potionDataModel.Bonus, potionDataModel.Effect, potionDataModel.Id, potionDataModel.Name,
            potionDataModel.Description, potionDataModel.Type, potionDataModel.CurrencyType, potionDataModel.Value,
            potionDataModel.Weight));
    }

    private async Task<IEnumerable<Item>> MapDataModelToItem(ListItemQuery query, CancellationToken cancellationToken)
    {
        var itemDataModels = await itemRepository.GetAllAsync(query, cancellationToken);

        return itemDataModels.Select(itemDataModel => new Item(itemDataModel.Id, itemDataModel.Name,
            itemDataModel.Description, itemDataModel.Type, itemDataModel.CurrencyType, itemDataModel.Value,
            itemDataModel.Weight));
    }
}