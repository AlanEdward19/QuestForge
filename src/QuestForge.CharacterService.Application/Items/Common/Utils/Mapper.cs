using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Items.Entities;

namespace QuestForge.CharacterService.Application.Items.Common.Utils;

public static class Mapper
{
    public static Item MapDataModelToEntity(ItemDataModel dataModel)
    {
        return dataModel switch
        {
            WeaponDataModel weaponDataModel =>
                new Weapon(weaponDataModel.Dice, weaponDataModel.DamageType,
                    weaponDataModel.DiceCount, weaponDataModel.Id, weaponDataModel.Name, weaponDataModel.Description,
                    weaponDataModel.Type, weaponDataModel.CurrencyType, weaponDataModel.Value, weaponDataModel.Weight),

            ArmorDataModel armorDataModel =>
                new Armor(armorDataModel.ArmorClass, armorDataModel.ArmorType,
                    armorDataModel.Modifier, armorDataModel.MaxModifier, armorDataModel.MinStrength,
                    armorDataModel.StealthDisadvantage, armorDataModel.Id, armorDataModel.Name,
                    armorDataModel.Description,
                    armorDataModel.Type, armorDataModel.CurrencyType, armorDataModel.Value, armorDataModel.Weight),

            PotionDataModel potionDataModel =>
                new Potion(potionDataModel.Dice, potionDataModel.DiceCount,
                    potionDataModel.Bonus, potionDataModel.Effect, potionDataModel.Id, potionDataModel.Name,
                    potionDataModel.Description, potionDataModel.Type, potionDataModel.CurrencyType,
                    potionDataModel.Value,
                    potionDataModel.Weight),

            ItemDataModel itemDataModel =>
                new Item(itemDataModel.Id, itemDataModel.Name,
                    itemDataModel.Description, itemDataModel.Type, itemDataModel.CurrencyType, itemDataModel.Value,
                    itemDataModel.Weight)
        };
    }

    public static IEnumerable<T> MapDataModelsToEntities<T>(IEnumerable<ItemDataModel> dataModels) where T : Item
    {
        return dataModels.Select(dataModel => (T) MapDataModelToEntity(dataModel));
    }
}