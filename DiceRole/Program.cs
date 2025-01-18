namespace DiceRole

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
             // Convert input to number
            int numOfRolls = Convert.ToInt32(Console.ReadLine());
            
            // Create dice roller
            DiceRoller roller = new DiceRoller();
            
            // Make array for roll results
            int[] rollCounts = roller.RollDice(numOfRolls);
            
            Console.WriteLine("");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numOfRolls);
            
            Console.WriteLine("\nResults: \n");
            
            //  Print chart for results
            for (int sum = 2; sum <= 12; sum++)
            {
                // Calculate the percentage 
                double percentage = (double)rollCounts[sum] / numOfRolls * 100.0;
                
                int stars = (int)Math.Round(percentage);
                
                // Build a string of *
                string starline = new string('*', stars);
                
                // Print the sum and asterisks
                Console.WriteLine(sum + ": " + starline);
            }

            Console.WriteLine("\nGoodbye!");
        }
    }
}