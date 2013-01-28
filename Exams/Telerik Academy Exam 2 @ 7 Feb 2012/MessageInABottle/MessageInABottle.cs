using System;
using System.Linq;

class MessageInABottle
{
    static int numberLenght = 4;

    static void Main()
    {

        int maxNumber = 1 << (numberLenght);

        maxNumber /= 2;

        Console.WriteLine(maxNumber);

        for (int currentCombination = 0; currentCombination < maxNumber; currentCombination++)
        {
            Console.WriteLine(Convert.ToString(currentCombination,2).PadLeft(numberLenght,'0'));
        }
    }

    static int[] ReturnCombinations(string number)
    {
        int[] result = new int[numberLenght];
        int nuberIndex;


        return result;
    }
}
