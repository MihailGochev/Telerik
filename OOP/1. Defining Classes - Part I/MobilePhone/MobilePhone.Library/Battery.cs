//battery characteristics
//(model, hours idle and hours talk)

namespace MobilePhone.Library
{
    using System;
    using System.Text;

    public class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType? type;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double? HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }

        public double? HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }

        public BatteryType? Type
        {
            get { return type; }
            set { type = value; }
        }

        public Battery(string model)
        {
            this.model = model;
            this.hoursIdle = null;
            this.hoursTalk = null;
            this.type = null;
        }

        public Battery(string model, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = null;
            this.hoursTalk = null;
            this.type = type;
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(string.Format("   Model: {0}{1}", model, Environment.NewLine));

            if (hoursIdle != null)
            {
                output.Append(string.Format("   Idle hours: {0}{1}", hoursIdle, Environment.NewLine));
            }
            if (hoursTalk != null)
            {
                output.Append(string.Format("   Talk hours: {0}{1}", hoursTalk, Environment.NewLine));
            }
            if (type != null)
            {
                output.Append(string.Format("   Battery Type: {0}{1}", type, Environment.NewLine));
            }

            return output.ToString();
        }
    }
}
