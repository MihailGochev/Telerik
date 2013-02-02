using System;
using System.Linq;

class BombingCuboids
{
    static char[, ,] cube;
    static int[,] bombs;
    static int[] result = new int[100];
    static int resultCount = 0;
    static int inputWidth;
    static int inputHeight;
    static int inputDepth;

    static void Main()
    {
        string inputString = Console.ReadLine();
        string[] input = inputString.Split(' ');

        inputWidth = int.Parse(input[0]);
        inputHeight = int.Parse(input[1]);
        inputDepth = int.Parse(input[2]);

        cube = new char[inputWidth, inputHeight, inputDepth];


        for (int height = 0; height < inputHeight; height++)
        {
            string line = Console.ReadLine();
            string[] lines = line.Split(' ');
            for (int depth = 0; depth < lines.Length; depth++)
            {
                for (int width = 0; width < lines[depth].Length; width++)
                {
                    cube[width, height, depth] = lines[depth][width];
                }
            }
        }

        int bombCount = int.Parse(Console.ReadLine());

        bombs = new int[bombCount, 4];

        for (int bomb = 0; bomb < bombCount; bomb++)
        {
            string bombLine = Console.ReadLine();
            string[] bombInfo = bombLine.Split(' ');

            bombs[bomb, 0] = int.Parse(bombInfo[0]);//w
            bombs[bomb, 1] = int.Parse(bombInfo[1]);//h
            bombs[bomb, 2] = int.Parse(bombInfo[2]);//d
            bombs[bomb, 3] = int.Parse(bombInfo[3]);//p
        }

        for (int bomb = 0; bomb < bombCount; bomb++)
        {
            DetonateBomb(bomb);
        }

        Console.WriteLine(resultCount);

        for (int letter = 0; letter < result.Length; letter++)
        {
            if (result[letter] > 0)
            {
                Console.WriteLine("{0} {1}", (char)(letter + 'A'), result[letter]);
            }
        }
    }

    static void DetonateBomb(int bomb)
    {
        int bombWidth = bombs[bomb, 0];
        int bombHeight = bombs[bomb, 1];
        int bombDepth = bombs[bomb, 2];
        int bombPower = bombs[bomb, 3] * bombs[bomb, 3];

        while (cube[bombWidth, bombHeight, bombDepth] == ' ')
        {
            bombHeight++;
            if (bombHeight >= inputHeight - 1)
            {
                break;
            }
        }

        for (int depth = 0; depth < inputDepth; depth++)
        {
            for (int height = 0; height < inputHeight; height++)
            {
                for (int width = 0; width < inputWidth; width++)
                {
                    int wDistance = (width - bombWidth) * (width - bombWidth);
                    int hDistance = (height - bombHeight) * (height - bombHeight);
                    int dDistance = (depth - bombDepth) * (depth - bombDepth);

                    if (wDistance + hDistance + dDistance <= bombPower)
                    {
                        if (cube[width, height, depth] != ' ' && cube[width, height, depth] != '\0')
                        {
                            result[cube[width, height, depth] - 'A']++;
                            resultCount++;
                            cube[width, height, depth] = ' ';
                        }
                    }
                }
            }
        }

        FallDown();
    }

    static void FallDown()
    {
        for (int depth = 0; depth < inputDepth; depth++)
        {
            for (int width = 0; width < inputWidth; width++)
            {
                int writeIndex = inputHeight;
                for (int height = inputHeight - 1; height >= 0; height--)
                {
                    if (cube[width, height, depth] != ' ')
                    {
                        writeIndex--;
                        cube[width, writeIndex, depth] = cube[width, height, depth];
                    }
                }
                for (int height = 0; height < writeIndex && height < inputHeight; height++)
                {
                    cube[width, height, depth] = ' ';
                }
            }
        }
    }
}