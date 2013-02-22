using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class DeleteWordsFromList
{
    static void Main()
    {
        try
        {
            DeleteWords();
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

    private static void DeleteWords()
    {
        StreamReader wordsFile = new StreamReader("../../words.txt");
        StreamReader inputFile = new StreamReader("../../input.txt");
        StreamWriter outputFile = new StreamWriter("../../output.txt");
        StringBuilder words = new StringBuilder();

        int index = 0;
        using (wordsFile)
        {
            string line = wordsFile.ReadLine();
            while (line != null)
            {
                line = line.Trim();
                if (index++ == 0)
                {
                    words.Append(line);
                }
                else
                {
                    words.Append(String.Format("|{0}", line));
                }
                line = wordsFile.ReadLine();
            }

        }
        string regex = String.Format(@"\b{0}\b", words.ToString());

        using (inputFile)
        {
            using (outputFile)
            {
                string line = inputFile.ReadLine();
                while (line != null)
                {
                    line = Regex.Replace(line, regex, String.Empty);
                    outputFile.WriteLine(line);
                    line = inputFile.ReadLine();
                }
            }
        }
    }
}
