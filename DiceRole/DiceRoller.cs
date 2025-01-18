namespace DiceRole
{
    public class DiceRoller
    {
        Random rand = new Random();

        //Rolls dice twice and adds their sum to an array
        public int[] RollDice(int numberOfRolls)
        {
            int[] results = new int[13];

            for (int i = 0; i < numberOfRolls; i++)
            {
                int d1 = rand.Next(1, 7);
                 int d2 = rand.Next(1, 7);
                int sum = d1 + d2;
                results[sum]++;
            }

            return results;
        }
    }
}