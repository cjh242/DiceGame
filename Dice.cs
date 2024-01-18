using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//a class for the dice
internal class Dice
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
