//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.

using System;
using System.Collections.Generic;
using MobilePhone.Library;

namespace GSMTest
{
    class GSMTest
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            List<GSM> mobilePhones = new List<GSM>();

            mobilePhones.Add(new GSM("3310", "Nokia", 1000M, "Ivan",
                new Display(1740, 33480, 160000000),
                new Battery("PK15", 50000, 2000, BatteryType.LiPol)));

            mobilePhones.Add(new GSM("Optimus 2x", "LG", 400M, "Gerasim",
                new Display(1740, 33480),
                new Battery("PK15", 50000, 2000, BatteryType.LiPol)));

            mobilePhones.Add(new GSM("Xperia Sola", "Sony", 600M,
                new Display(1740, 33480, 160000000),
                new Battery("PK15")));

            mobilePhones.Add(new GSM("Lumia 720", "Nokia", 700M,
                new Display(1740, 33480, 160000000),
                new Battery("PK15")));

            mobilePhones.Add(new GSM("Samsung", "Galaxy S", new
                Display(),
                new Battery("PK15", BatteryType.LiPol)));

            mobilePhones.Add(new GSM("One X", "HTC", 500M, "Georgi"));

            mobilePhones.Add(new GSM("Hero", "HTC"));

            mobilePhones.Add(GSM.IPhone4S);

            foreach (var phone in mobilePhones)
            {
                Console.WriteLine(new string('*', 50));
                Console.WriteLine(phone);
            }
        }
    }
}
