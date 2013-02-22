using System;

class Midget
{
    static void Main()
    {
        //Input
        string valley = Console.ReadLine();

        //Parsing the valley
        string[] valleyNumbersString = valley.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        long[] valleyNumbers = new long[valleyNumbersString.Length];

        for (int numberIndex = 0; numberIndex < valleyNumbersString.Length; numberIndex++)
        {
            valleyNumbers[numberIndex] = long.Parse(valleyNumbersString[numberIndex]);
        }

        //Parsing the patterns
        long numberOfPatterns = long.Parse(Console.ReadLine());
        long[][] patterns = new long[numberOfPatterns][];

        for (int patternIndex = 0; patternIndex < numberOfPatterns; patternIndex++)
        {
            string pattern = Console.ReadLine();
            string[] patternNumbersString = pattern.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            patterns[patternIndex] = new long[patternNumbersString.Length];

            for (int numberIndex = 0; numberIndex < patternNumbersString.Length; numberIndex++)
            {
                patterns[patternIndex][numberIndex] = long.Parse(patternNumbersString[numberIndex]);
            }
        }

        //Boolean array used to keep track of the visited parts in the valley
        bool[] visited = new bool[valleyNumbersString.Length];


        long index = 0;
        long result = 0;
        long maximumResult = long.MinValue;
        bool escape = false;

        //Calculating the result for each pattern
        for (int pattern = 0; pattern < patterns.Length; pattern++)
        {
            index = 0;
            while (true)
            {
                //Following the current pattern until we leave the valley
                for (int patternIndex = 0; patternIndex < patterns[pattern].Length; patternIndex++)
                {
                    if (index >= valleyNumbers.Length || index < 0 || visited[index])
                    {
                        //End of the current pattern
                        escape = true;
                        break;
                    }
                    result += valleyNumbers[index];
                    visited[index] = true;
                    index += patterns[pattern][patternIndex];
                }
                if (escape)
                {
                    //Getting the max result from a pattern
                    if (result > maximumResult)
                    {
                        maximumResult = result;
                    }
                    result = 0;
                    escape = false;
                    visited = new bool[valleyNumbersString.Length];
                    break;
                }
            }
        }

        //Printing the result
        Console.WriteLine(maximumResult);
    }
}