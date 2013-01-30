using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        try
        {
            WordCounter();
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (OutOfMemoryException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void WordCounter()
    {
        StreamReader wordsFile = new StreamReader("../../words.txt");
        StreamReader inputFile = new StreamReader("../../input.txt");
        StreamWriter outputFile = new StreamWriter("../../output.txt");
        Hashtable wordCount = new Hashtable();
        List<string> words = new List<string>();

        using (wordsFile)
        {
            string line = wordsFile.ReadLine();
            while (line != null)
            {
                words.Add(line.Trim());
                line = wordsFile.ReadLine();
            }

        }

        using (inputFile)
        {
            string line = inputFile.ReadLine();
            bool firstPass = false;
            while (line != null)
            {

                foreach (string item in words)
                {
                    string regex = String.Format("\\b{0}\\b", item);
                    if (firstPass)
                    {
                        wordCount[item] = ((int)wordCount[item] + Regex.Matches(line, regex).Count);
                    }
                    else
                    {
                        wordCount[item] = Regex.Matches(line, regex).Count;
                    }
                }
                firstPass = true;
                line = inputFile.ReadLine();
            }

        }
        KeyValuePair<string, int>[] output = new KeyValuePair<string, int>[wordCount.Count];

        int index = 0;
        foreach (DictionaryEntry item in wordCount)
        {
            output[index++] = new KeyValuePair<string, int>((string)item.Key, (int)item.Value);
        }

        Array.Sort<KeyValuePair<string, int>>(output, (a, b) => a.Value.CompareTo(b.Value));

        using (outputFile)
        {
            foreach (KeyValuePair<string, int> item in output)
            {
                outputFile.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }
    }
}