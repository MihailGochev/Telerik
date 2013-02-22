//battery characteristics
//(model, hours idle and hours talk)

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

        public Battery()
        {
            this.model = "Generic Battery";
            this.hoursIdle = 32;
            this.hoursTalk = 6;
            this.type = BatteryType.LiIon;
        }

        public Battery(string model)
        {
            this.model = model;
            this.hoursIdle = 32;
            this.hoursTalk = 6;
            this.type = BatteryType.LiIon;
        }

        public Battery(string model, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = 32;
            this.hoursTalk = 6;
            this.type = type;
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }
    }
}
