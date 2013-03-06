using System;
using GenericList.Library;

namespace GenericList.Test
{
    class Test
    {
        static void Main()
        {
            GenericList<int> myList = new GenericList<int>(3);

            Console.WriteLine("Adding elements without exceeding the initial size.");
            myList.Add(5);
            myList.Add(3);
            myList.Add(4);
            Console.WriteLine(myList);

            Console.WriteLine("Adding elements after the initial size was exceeded.");
            myList.Add(10);
            myList.Add(11);
            myList.Add(12);
            myList.Add(512);
            myList.Add(13);
            myList.Add(14);
            myList.Add(333);
            myList.Add(15);
            Console.WriteLine(myList);


            Console.WriteLine("Removing the first item several times.");
            myList.RemoveAt(0);
            myList.RemoveAt(0);
            myList.RemoveAt(0);
            Console.WriteLine(myList);

            Console.WriteLine("Removing elements by given value (333 and 512).");
            myList.Remove(512);
            myList.Remove(333);
            Console.WriteLine(myList);


            Console.WriteLine("Inserting at position 0.");
            myList.Insert(0, 10000);
            Console.WriteLine(myList);

            Console.WriteLine("Inserting at position 7.");
            myList.Insert(7, -10000);
            Console.WriteLine(myList);

            Console.WriteLine("Writing max value.");
            Console.WriteLine(myList.Max());

            Console.WriteLine("Writing min value.");
            Console.WriteLine(myList.Min());

            Console.WriteLine("Printing the list items using indexers and Count property");
            for (int index = 0; index < myList.Count; index++)
            {
                Console.WriteLine(myList[index]);
            }

            Console.WriteLine("Clearing the array.");
            myList.Clear();
            Console.WriteLine(myList);


            ////SAME TESTS WITH STRING
            //GenericList<string> myStringList = new GenericList<string>(3);

            //Console.WriteLine("Adding elements without exceeding the initial size.");
            //myStringList.Add("aaa");
            //myStringList.Add("bbb");
            //myStringList.Add("ccc");
            //Console.WriteLine(myStringList);

            //Console.WriteLine("Adding elements after the initial size was exceeded.");
            //myStringList.Add("ddd");
            //myStringList.Add("eee");
            //myStringList.Add("fff");
            //myStringList.Add("GOSHO");
            //myStringList.Add("IVAN");
            //myStringList.Add("nnnn");
            //Console.WriteLine(myStringList);


            //Console.WriteLine("Removing the first item several times.");
            //myStringList.RemoveAt(0);
            //myStringList.RemoveAt(0);
            //myStringList.RemoveAt(0);
            //Console.WriteLine(myStringList);

            //Console.WriteLine("Removing elements by given value (GOSHO and IVAN).");
            //myStringList.Remove("GOSHO");
            //myStringList.Remove("IVAN");
            //Console.WriteLine(myStringList);


            //Console.WriteLine("Inserting at position 0.");
            //myStringList.Insert(0, "aaaa");
            //Console.WriteLine(myStringList);

            //Console.WriteLine("Inserting at position 7.");
            //myStringList.Insert(7, "xxxx");
            //Console.WriteLine(myStringList);

            //Console.WriteLine("Writing max value.");
            //Console.WriteLine(myStringList.Max());

            //Console.WriteLine("Writing min value.");
            //Console.WriteLine(myStringList.Min());

            //Console.WriteLine("Printing the list items using indexers and Count property");
            //for (int index = 0; index < myStringList.Count; index++)
            //{
            //    Console.WriteLine(myStringList[index]);
            //}

            //Console.WriteLine("Clearing the array.");
            //myStringList.Clear();
            //Console.WriteLine(myStringList);

        }
    }
}
