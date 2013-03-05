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
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Model cannot be null!");
                }

                if (value == String.Empty)
                {
                    throw new ArgumentException("Empty model!");
                }
                model = value;
            }
        }

        public double? HoursIdle
        {

            get { return hoursIdle; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Hours cannot be null!");
                }

                if (value < 0)
                {
                    throw new ArgumentException("Hours cannot be negative!");
                }

                hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Hours cannot be null!");
                }

                if (value < 0)
                {
                    throw new ArgumentException("Hours cannot be negative!");
                }
                hoursTalk = value;
            }
        }

        public BatteryType? Type
        {
            get { return type; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Battery type cannot be null!");
                }

                type = value;
            }
        }

        public Battery(string model)
        {
            this.Model = model;     //setting the property
            this.hoursIdle = null;  //setting the field
            this.hoursTalk = null;  //setting the field
            this.type = null;       //setting the field
        }

        public Battery(string model, BatteryType type)
            : this(model)
        {
            this.hoursIdle = null;  //setting the field
            this.hoursTalk = null;  //setting the field
            this.Type = type;       //setting the property
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type)
            : this(model, type)
        {
            this.HoursIdle = hoursIdle;  //setting the property
            this.HoursTalk = hoursTalk;  //setting the property
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
