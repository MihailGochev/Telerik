using System;
using System.IO;
using System.Linq;
using System.Text;

class ExtractXML
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\input.xml");
        StringBuilder output = new StringBuilder();
        int letter;
        int state = 0;

        using (inputFile)
        {
            while ((letter = inputFile.Read()) != -1)
            {
                switch (state)
                {
                    case 0:
                        if (letter == '<')
                        {
                            state = 1;
                        }
                        else
                        {
                            output.Append((char)letter);
                        }
                        break;
                    case 1:
                        if (letter == '>')
                        {
                            state = 0;
                        }
                        break;
                }
            }
        }

        Console.WriteLine(output);
    }
}