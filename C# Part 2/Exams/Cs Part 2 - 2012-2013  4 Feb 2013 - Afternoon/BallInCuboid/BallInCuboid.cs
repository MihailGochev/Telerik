using System;
using System.Linq;

class BallInCuboid
{
    static string[, ,] cube;
    static int inputWidth;
    static int inputHeight;
    static int inputDepth;
    static int lastWidth;
    static int lastHeight;
    static int lastDepth;

    static void Main()
    {

        //Input
        string inputString = Console.ReadLine();
        string[] input = inputString.Split(' ');

        //The size of the cube
        inputWidth = int.Parse(input[0]);
        inputHeight = int.Parse(input[1]);
        inputDepth = int.Parse(input[2]);

        cube = new string[inputWidth, inputHeight, inputDepth];

        //Parsing each row
        for (int height = 0; height < inputHeight; height++)
        {
            string line = Console.ReadLine();
            string[] lines = line.Split('|');
            //Parsing each layer
            for (int depth = 0; depth < lines.Length; depth++)
            {
                //Parsing each column
                string[] numbers = lines[depth].Split(new string[] { ")(", }, StringSplitOptions.RemoveEmptyEntries);
                for (int width = 0; width < inputWidth; width++)
                {
                    string block = numbers[width];
                    //Removing the brackets from each block
                    block = block.Trim(new char[] { '(', ')', ' ' });
                    cube[width, height, depth] = block;
                }
            }
        }

        inputString = Console.ReadLine();
        input = inputString.Split(' ');

        int ballWidth = int.Parse(input[0]);
        int ballDepth = int.Parse(input[1]);

        lastWidth = ballWidth;
        lastHeight = 0;
        lastDepth = ballDepth;

        //Starting the first turn
        PlayTurn(ballWidth, 0, ballDepth);
    }

    static void PlayTurn(int width, int height, int depth)
    {

        if (OutOfBounds(width, height, depth))
        {
            //The ball has gone outside the cube
            Console.WriteLine("No");
            Console.WriteLine("{0} {1} {2}", lastWidth, lastHeight, lastDepth);
            return;
        }

        if (cube[width, height, depth][0] == 'T')
        {
            //The ball has reached a teleport 
            string[] numbers = cube[width, height, depth].Split(' ');
            int w = int.Parse(numbers[1]);
            int d = int.Parse(numbers[2]);
            PlayTurn(w, height, d);
            return;
        }

        if (cube[width, height, depth] == "B")
        {
            //The ball has reached a basket. 
            Console.WriteLine("No");
            Console.WriteLine("{0} {1} {2}", width, height, depth);
            return;
        }

        if (height == inputHeight - 1)
        {
            //The ball has reached the bottom of the cube. 
            Console.WriteLine("Yes");
            Console.WriteLine("{0} {1} {2}", width, height, depth);
            return;
        }

        //Keeping the previous coordinates of the cube in case it leaves the borders.
        lastWidth = width;
        lastHeight = height;
        lastDepth = depth;

        //Switching each command
        switch (cube[width, height, depth])
        {
            case "S L":
                PlayTurn(width - 1, height + 1, depth);
                break;
            case "S R":
                PlayTurn(width + 1, height + 1, depth);
                break;
            case "S B":
                PlayTurn(width, height + 1, depth + 1);
                break;
            case "S F":
                PlayTurn(width, height + 1, depth - 1);
                break;
            case "S FL":
                PlayTurn(width - 1, height + 1, depth - 1);
                break;
            case "S FR":
                PlayTurn(width + 1, height + 1, depth - 1);
                break;
            case "S BL":
                PlayTurn(width - 1, height + 1, depth + 1);
                break;
            case "S BR":
                PlayTurn(width + 1, height + 1, depth + 1);
                break;
            case "E":
                PlayTurn(width, height + 1, depth);
                break;
        }
    }

    //Checking whether the coordinates are outside the bounds of the cube
    static bool OutOfBounds(int width, int height, int depth)
    {
        if (width >= inputWidth || width < 0 || height >= inputHeight || height < 0 || depth >= inputDepth || depth < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}