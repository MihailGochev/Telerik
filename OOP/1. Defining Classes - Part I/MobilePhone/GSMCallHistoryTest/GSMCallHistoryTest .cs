//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//  Create an instance of the GSM class.
//  Add few calls.
//  Display the information about the calls.
//  Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//  Remove the longest call from the history and calculate the total price again.
//  Finally clear the call history and print it.

using System;
using MobilePhone.Library;

namespace GSMCallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            GSM myPhone = new GSM("3310", "Nokia", 1000M, "Ivan", new Display(1740, 33480, 160000000), new Battery("PK15", 50000, 2000, BatteryType.LiPol));


            myPhone.AddCall("08999333888", DateTime.Now, 200);
            myPhone.AddCall("08999333888", DateTime.Now, 300);
            myPhone.AddCall("08888333888", DateTime.Now, 400);
            myPhone.AddCall("08888333888", DateTime.Now, 500);
            myPhone.AddCall("09999999999", DateTime.Now, 1);
            myPhone.AddCall("08888555555", DateTime.Now, 200);
            myPhone.AddCall("08888555555", DateTime.Now, 300);
            myPhone.AddCall("08888555555", DateTime.Now, 400);
            myPhone.AddCall("08888555555", DateTime.Now, 10101);

            Console.WriteLine(myPhone.ShowCallHistory());

            Console.WriteLine("Total call price: {0:C2}", myPhone.TotalCallPrice(0.37M));

            myPhone.DeleteLongestCall();
            myPhone.DeleteShortestCall();
            myPhone.DeleteCall(3);

            Console.WriteLine(new string('*', 50));
            Console.WriteLine(myPhone.ShowCallHistory());

            myPhone.ClearCallHistory();

            Console.WriteLine(new string('*', 50));
            Console.WriteLine(myPhone.ShowCallHistory());

        }
    }
}
