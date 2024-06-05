using QuestForge.CharacterService.Core.Common.Abstracts.Base;
using QuestForge.CharacterService.Core.Common.DataModels;
using QuestForge.CharacterService.Core.Common.Enums;
using QuestForge.CharacterService.Core.Items.Enums;

namespace QuestForge.CharacterService.Core.Items.Entities;

public class Potion : Item
{
    public int Dice { get; private set; }
    public int DiceCount { get; private set; }
    public int Bonus { get; private set; }
    public EPotionEffect Effect { get; private set; }

    public Potion() : base() { }

    public Potion(int dice, int diceCount, int bonus, EPotionEffect effect, Guid id, string name, string description, EItemType type,
        ECurrencyType currencyType, double value, double weight) : base(id, name, description, type, currencyType, value, weight)
    {
        Dice = dice;
        DiceCount = diceCount;
        Bonus = bonus;
        Effect = effect;
    }

    public Potion(BaseDataModel dataModel) : base(dataModel)
    {
        var parsedDataModel = dataModel as PotionDataModel;

        Dice = parsedDataModel.Dice;
        DiceCount = parsedDataModel.DiceCount;
        Bonus = parsedDataModel.Bonus;
        Effect = parsedDataModel.Effect;
    }

    public void UpdateDice(int? dice)
    {
        if (dice.HasValue && !Dice.Equals(dice))
            Dice = dice.Value;
    }

    public void UpdateDiceCount(int? diceCount)
    {
        if (diceCount.HasValue && !DiceCount.Equals(diceCount))
            DiceCount = diceCount.Value;
    }

    public void UpdateBonus(int? bonus)
    {
        if (bonus.HasValue && !Bonus.Equals(bonus))
            Bonus = bonus.Value;
    }

    public void UpdateEffect(EPotionEffect? effect)
    {
        if (effect.HasValue && !Effect.Equals(effect))
            Effect = effect.Value;
    }
}