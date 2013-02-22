using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class AllignBoth
{
    static void Main()
    {
        //Input
        StringBuilder input = new StringBuilder();
        int inputLines = int.Parse(Console.ReadLine());
        int lineLenght = int.Parse(Console.ReadLine());
        for (int line = 0; line < inputLines; line++)
        {
            //Appending every input line, adding two spaces to avoid concatenation of the words inside
            input.Append(string.Format(" {0} ", Console.ReadLine()));
        }

        //spliting the words to a string array
        string[] words = input.ToString().Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        //declaring a list to hold each line
        List<string> currentLine = new List<string>();

        int wordIndex = 0;
        while (wordIndex < words.Length)
        {
            //adding the lenght of the word to the current line lenght
            int currentLineLengt = words[wordIndex].Length;

            //adding words to the list until the max lenght is reached
            currentLine.Add(words[wordIndex++]);
            while (wordIndex < words.Length)
            {
                if (currentLineLengt + words[wordIndex].Length < lineLenght)
                {
                    currentLineLengt += words[wordIndex].Length + 1;
                    currentLine.Add(words[wordIndex++]);
                }
                else
                {
                    break;
                }
            }
            //printing the line and clearing the list
            PrintLine(currentLine, lineLenght);
            currentLine.Clear();
        }
    }


    static void PrintLine(List<string> words, int lineLenght)
    {
        //If there is only one word on the line we are printing it
        if (words.Count == 1)
        {
            Console.WriteLine(words[0]);
            return;
        }

        int wordsLenght = 0;
        int countOfGaps = words.Count - 1;

        foreach (var item in words)
        {
            wordsLenght += item.Length;
        }

        //calculating the total size of the gaps between the words
        int gap = lineLenght - wordsLenght;
        //calculating the size of each gap
        int initialGap = gap / countOfGaps;
        //calculating the space remaining
        int gapLeft = gap % countOfGaps;

        for (int index = 0; index < words.Count; index++)
        {
            if (index == 0)
            {
                Console.Write(words[index]);
            }
            else if (index <= gapLeft)
            {
                //adding a single space to compensate for the remaining space
                Console.Write("{0}{1}", new String(' ', initialGap + 1), words[index]);
            }
            else
            {
                Console.Write("{0}{1}", new String(' ', initialGap), words[index]);
            }
        }

        //Printing a new line
        Console.WriteLine();
    }
}