using System;
using System.Linq;

class ReadLetters
{
    static void Main()
    {
        string input = "asihascoasbnoscaibcosaoasjovifaybuiwvebhgacbeuwgyjopnucwyaeg1523523ucnoipopouiacnoewnoacenacicbbbtuacrucuae5123sjvasdvjrnowaetmampggsdfomdpsdbsonibsdoibniobsdobdsndbsoibdssadsdamopacopsmdoipbvnoasdibndvuios";
        int[] output = new int['z' - '0'];

        foreach (var letter in input)
        {
            output[letter - '0']++;
        }

        for (int index = 0; index < output.Length; index++)
        {
            if (output[index] > 0)
            {
                Console.WriteLine("{0} - {1}", (char)(index + '0'), output[index]);
            }
        }
    }
}

