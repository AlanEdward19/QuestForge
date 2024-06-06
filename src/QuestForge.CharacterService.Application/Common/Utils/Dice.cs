namespace QuestForge.CharacterService.Application.Common.Utils;

public static class Dice
{
    public static int CalculateRandomDice(int dice, int diceAmount)
    {
        Random random = new Random();
        int total = 0;

        for (int i = 0; i < diceAmount; i++)
            total += random.Next(1, dice + 1);

        return total;
    }
}