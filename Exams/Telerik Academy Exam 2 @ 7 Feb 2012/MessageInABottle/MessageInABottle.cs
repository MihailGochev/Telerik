using System;
using System.Linq;

class MessageInABottle
{

    static void Main()
    {
        int numberLenght = 4;
        string code = "ABCD";
        int maxNumber = 1 << (numberLenght - 1);


        for (int currentCombination = 0; currentCombination < maxNumber; currentCombination++)
        {
            Console.WriteLine();
            Console.WriteLine(Convert.ToString(currentCombination, 2).PadLeft(numberLenght, '0'));
            int[] result = ReturnCombinations(Convert.ToString(currentCombination, 2).PadLeft(numberLenght, '0'));



            int index = 0;
            int startIndex = 0;

            while (result[index] > 0)
            {
                Console.WriteLine(result[index]);
                Console.WriteLine(code.Substring(index, result[index]));
                if (result[index] == 1)
                {
                    startIndex += result[index] + 1;

                }
                else
                {
                    startIndex += result[index];
                }
                index++;
            }
        }
    }

    static int[] ReturnCombinations(string number)
    {
        int[] result = new int[number.Length + 1];
        int numberIndex = 0;
        int lenght = 1;
        char currentDigit = number[0];

        for (int index = 1; index < number.Length; index++)
        {
            if (currentDigit == number[index])
            {
                lenght++;
            }
            else
            {
                currentDigit = number[index];
                result[numberIndex++] = lenght;
                lenght = 1;
            }
        }
        result[numberIndex++] = lenght;
        result[numberIndex] = -1;
        return result;
    }
}
