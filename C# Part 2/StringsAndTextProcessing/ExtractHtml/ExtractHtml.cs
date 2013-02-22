using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string input = @"<html>
<head><title>News</title></head>
<body><p><a href=""http://academy.telerik.com"">Telerik
Academy</a>aims to provide free real-world practical
training for young people who want to turn into
skillful .NET software engineers.</p></body>
</html>
";
        int state = 0;
        for (int index = 0; index < input.Length; index++)
        {
            switch (state)
            {
                case 0:
                    if (input[index] == '<')
                    {
                        state = 1;
                    }
                    else
                    {
                        Console.Write(input[index]);
                    }
                    break;
                case 1:
                    if (input[index] == '>')
                    {
                        state = 0;
                    }
                    break;
            }
        }
    }
}
