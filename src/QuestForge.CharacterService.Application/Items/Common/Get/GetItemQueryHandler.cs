using QuestForge.CharacterService.Core.Common.Contracts.Database;
using QuestForge.CharacterService.Core.Common.Contracts.Services;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Items.Entities;
using QuestForge.CharacterService.Core.Items.Enums;

namespace QuestForge.CharacterService.Application.Items.Common.Get;

public class GetItemQueryHandler(IRepository<ItemDataModel> itemRepository, IRepository<WeaponDataModel> weaponRepository,
        IRepository<PotionDataModel> potionRepository, IRepository<ArmorDataModel> armorRepository)
    : IHandler<GetItemQuery, Item>
{
    public async Task<Item> Handle(GetItemQuery command, CancellationToken cancellationToken) => command.Type switch
    {
        EItemType.Weapon => await MapDataModelToWeapon(command, cancellationToken),
        EItemType.Potion => await MapDataModelToPotion(command, cancellationToken),
        EItemType.Armor => await MapDataModelToArmor(command, cancellationToken),
        _ => await MapDataModelToItem(command, cancellationToken)
    };

    private async Task<Item> MapDataModelToWeapon(GetItemQuery query, CancellationToken cancellationToken)
    {
        var weaponDataModel = await weaponRepository.GetByIdAsync(query, cancellationToken);

        return new Weapon(weaponDataModel.Dice, weaponDataModel.DamageType, weaponDataModel.DiceCount,
            weaponDataModel.Id, weaponDataModel.Name, weaponDataModel.Description, weaponDataModel.Type,
            weaponDataModel.CurrencyType, weaponDataModel.Value, weaponDataModel.Weight);
    }

    private async Task<Item> MapDataModelToArmor(GetItemQuery query, CancellationToken cancellationToken)
    {
        var armorDataModel = await armorRepository.GetByIdAsync(query, cancellationToken);

        return new Armor(armorDataModel.ArmorClass, armorDataModel.ArmorType, armorDataModel.Modifier,
            armorDataModel.MaxModifier, armorDataModel.MinStrength, armorDataModel.StealthDisadvantage,
            armorDataModel.Id, armorDataModel.Name, armorDataModel.Description, armorDataModel.Type,
            armorDataModel.CurrencyType, armorDataModel.Value, armorDataModel.Weight);
    }

    private async Task<Item> MapDataModelToPotion(GetItemQuery query, CancellationToken cancellationToken)
    {
        var potionDataModel = await potionRepository.GetByIdAsync(query, cancellationToken);

        return new Potion(potionDataModel.Dice, potionDataModel.DiceCount, potionDataModel.Bonus,
            potionDataModel.Effect, potionDataModel.Id, potionDataModel.Name, potionDataModel.Description,
            potionDataModel.Type, potionDataModel.CurrencyType, potionDataModel.Value, potionDataModel.Weight);
    }

    private async Task<Item> MapDataModelToItem(GetItemQuery query, CancellationToken cancellationToken)
    {
        var itemDataModel = await itemRepository.GetByIdAsync(query, cancellationToken);

        return new Item(itemDataModel.Id, itemDataModel.Name, itemDataModel.Description, itemDataModel.Type,
            itemDataModel.CurrencyType, itemDataModel.Value, itemDataModel.Weight);
    }
}