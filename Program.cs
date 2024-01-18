//dice game that randomly simulates the rolling of two dice and prints the percent of the total 
//that each number was using astrix 
//conway hogan

using System;

//class for the game
internal class DiceGame
{
    private static void Main()
    {
        //print output
        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.WriteLine("How many dice rolls would you like to simulate?");

        //get input
        int numRolls = int.Parse(Console.ReadLine());

        Dice dice = new Dice();

        int[] results = dice.RollUm(numRolls);

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

        Console.WriteLine("Total number of rolls = " + numRolls);

        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / numRolls;
            string asterisks = new string('*', percentage);
            Console.WriteLine($"{i}: {asterisks}");
        }

        Console.WriteLine("Thank you for using dice simulator. Goodbye!");


    }

}
//a class for the dice
class Dice
{
    private Random random;

    //instance of random
    public Dice()
    { 
        random = new Random();
    }

    //function for rolling the dice and returning the array of results
    public int[] RollUm(int numRolls)
    {
        int[] results = new int[13];

        //loop to do it the number of times the user requests
        for (int i = 0; i < numRolls; i++)
        {
            //rolls dice and adds sum
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            results[sum]++;
        }

        //returns the array
        return results;
    }
}
