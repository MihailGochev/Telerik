using System;
using System.Linq;

class EncodeString
{
    static void Main()
    {
        string input = "The quick brown fox jumps over the lazy dog.";
        string cipher = "monkey";
        char[] output = new char[input.Length];


        for (int index = 0; index < input.Length; index++)
        {
            output[index] = (char)(input[index] ^ cipher[index % cipher.Length]);
        }

        Console.WriteLine(output);
    }
}
