﻿using System;
using System.Linq;

class Alphabet
{
    static void Main()
    {
        char[] alphabet = new char[58];
        for (int element = 65; element < 123; element++)
        {
            alphabet[element - 65] = (char)element;
        }

        Console.Write("Enter a word: ");

        string wordString = Console.ReadLine();

        char[] word = wordString.ToCharArray();

        for (int index = 0; index < word.Length; index++)
        {
            int position = word[index] - 65;
            Console.WriteLine("Letter {0} | Possition in the array {1,2} | Array {2}", word[index], position, alphabet[position]);
        }
    }
}