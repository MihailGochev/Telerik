//battery characteristics
//(model, hours idle and hours talk)
using System;

namespace MobilePhone.Library
{
    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType type;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public double HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public BatteryType Type
        {
            get { return type; }
            set { type = value; }
        }

    }
}
