using System;
using System.Collections.Generic;
using MobilePhone.Library;

namespace GSMTest
{
    class GSMTest
    {
        static void Main()
        {
            List<GSM> mobilePhones = new List<GSM>();
            Battery currentBattery = new Battery("battery", 50, 20, BatteryType.LiPol);
            Display currentDisplay = new Display(740, 480, 160000000);

            mobilePhones.Add(new GSM("Nokia", "Nokia",currentDisplay,currentBattery));

            Console.WriteLine(mobilePhones[0]);
        }
    }
}
