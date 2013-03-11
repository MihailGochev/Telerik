using System;

namespace InvalidRangeException
{
    class Test
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int[] numbers = { 5, 3, 76, 7, 8, 1, 23, 5 };

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Testing the exception with an int array:");
            try
            {
                PrintElementsInArray(numbers, -5, 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Testing the exception with DateTime:");
            try
            {
                CheckDate(new DateTime(1970, 3, 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }

        static void PrintElementsInArray(int[] numbers, int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex > numbers.Length)
            {
                throw new InvalidRangeException<int>("Invalid start/end index", startIndex, endIndex);
            }

            for (int index = startIndex; index < endIndex; index++)
            {
                Console.Write(numbers[index]);
            }
            Console.WriteLine();
        }

        static void CheckDate(DateTime date)
        {
            if (date.Year < 1980 || date.Year > 2013)
            {
                throw new InvalidRangeException<DateTime>("Invalid start/end index", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31), new IndexOutOfRangeException());
            }
            Console.WriteLine(date);
        }
    }
}
