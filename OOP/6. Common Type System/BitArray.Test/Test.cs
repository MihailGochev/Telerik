using System;
using BitArray.Library;

namespace BitArray.Test
{
    class Test
    {
        static void Main()
        {
            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Creating an empty bit array and printing it:");
            BitArray64 firstArray = new BitArray64();
            Console.WriteLine(firstArray);

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Creating a bit array with uint value 515225125512125 and printing it:");
            BitArray64 secondArray = new BitArray64(515225125512125);
            Console.WriteLine(secondArray);
            Console.WriteLine("Printing its hashcode:");
            Console.WriteLine(secondArray.GetHashCode());

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Printing the same array using foreach (IEnumerable example):");
            foreach (var item in secondArray)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Setting some values using indexers in the first array (at index 4 15 and 37):");
            firstArray[4] = 1;
            firstArray[15] = 1;
            firstArray[37] = 1;
            Console.WriteLine(firstArray);

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Filling the empty array with 1 using a loop and printing it:");
            for (int index = 0; index < 64; index++)
            {
                firstArray[index] = 1;
            }
            Console.WriteLine(firstArray);

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Filling the second array with 1 using a loop and printing it:");
            for (int index = 0; index < 64; index++)
            {
                secondArray[index] = 1;
            }
            Console.WriteLine(secondArray);

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Checking for equality of the two arrays:");
            Console.WriteLine("Using == --> {0}", firstArray == secondArray);
            Console.WriteLine("Using != --> {0}", firstArray != secondArray);
            Console.WriteLine("Using .Equals() --> {0}", firstArray.Equals(secondArray));

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Setting the two arrays to zero and checking them again:");
            for (int index = 0; index < 64; index++)
            {
                firstArray[index] = 0;
                secondArray[index] = 0;
            }
            Console.WriteLine("Using == --> {0}", firstArray == secondArray);
            Console.WriteLine("Using != --> {0}", firstArray != secondArray);
            Console.WriteLine("Using .Equals() --> {0}", firstArray.Equals(secondArray));

            //Errors
            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Trying some exceptions:");
            try
            {
                Console.WriteLine("Giving invalid index:");
                firstArray[555] = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Giving invalid value:");
                firstArray[15] = 5;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Using .Equals() on bit array and an object with different type:");
                object number = new DateTime();
                firstArray.Equals(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}