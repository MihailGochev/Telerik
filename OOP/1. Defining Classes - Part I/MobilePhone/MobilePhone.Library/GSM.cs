//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics
//(model, hours idle and hours talk) and display characteristics (size and number of colors). 
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

namespace MobilePhone.Library
{
    using System;
    using System.Text;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Display displayInformation;
        private Battery batteryInformation;


        //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        static public GSM IPhone4S = new GSM("IPhone4S", "Apple", 1500M, new Display(640, 960, 16000000), new Battery("LIS1445APPC", 200, 14, BatteryType.LiPol));

        public string Model
        {
            get { return model; }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Model cannot be an empty string!");
                }

                if (value == null)
                {
                    throw new NullReferenceException("Model cannot be null!");
                }

                model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Manufacturer cannot be an empty string!");
                }

                if (value == null)
                {
                    throw new NullReferenceException("Manufacturer cannot be null!");
                }

                manufacturer = value;
            }
        }

        public decimal Price
        {
            get { return price.GetValueOrDefault(); }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be negative or zero!");
                }

                price = value;
            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Owner cannot be an empty string!");
                }

                if (value == null)
                {
                    throw new NullReferenceException("Manufacturer cannot be null!");
                }

                owner = value;
            }
        }

        public Battery BatteryInformation
        {
            get { return batteryInformation; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Battery information cannot be null!");
                }

                batteryInformation = value;
            }
        }

        public Display DisplayInformation
        {
            get { return displayInformation; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Display information cannot be null!");
                }

                displayInformation = value;
            }
        }

        public GSM(string model, string manufacturer)
        {
            if (model == String.Empty)
            {
                throw new ArgumentException("Model cannot be an empty string!");
            }

            if (model == null)
            {
                throw new NullReferenceException("Model cannot be null!");
            }

            if (manufacturer == String.Empty)
            {
                throw new ArgumentException("Manufacturer cannot be an empty string!");
            }

            if (manufacturer == null)
            {
                throw new NullReferenceException("Manufacturer cannot be null!");
            }

            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
            this.displayInformation = null;
            this.batteryInformation = null;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer)
        {

            if (owner == String.Empty)
            {
                throw new ArgumentException("Owner cannot be an empty string!");
            }

            if (owner == null)
            {
                throw new NullReferenceException("Manufacturer cannot be null!");
            }

            if (price <= 0)
            {
                throw new ArgumentException("Price cannot be negative or zero!");
            }

            this.price = price;
            this.owner = owner;

        }

        public GSM(string model, string manufacturer, Display displayInformation, Battery batteryInformation)
            : this(model, manufacturer)
        {

            if (displayInformation == null)
            {
                throw new NullReferenceException("Display information cannot be null!");
            }

            if (batteryInformation == null)
            {
                throw new NullReferenceException("Battery information cannot be null!");
            }

            this.displayInformation = displayInformation;
            this.batteryInformation = batteryInformation;
        }


        public GSM(string model, string manufacturer, decimal price, Display displayInformation, Battery batteryInformation)
            : this(model, manufacturer, displayInformation, batteryInformation)
        {

            if (price <= 0)
            {
                throw new ArgumentException("Price cannot be negative or zero!");
            }

            this.price = price;
            this.owner = null;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Display displayInformation, Battery batteryInformation)
            : this(model, manufacturer, price, displayInformation, batteryInformation)
        {

            if (owner == String.Empty)
            {
                throw new ArgumentException("Owner cannot be an empty string!");
            }

            if (owner == null)
            {
                throw new NullReferenceException("Manufacturer cannot be null!");
            }

            this.owner = owner;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(string.Format("Model: {0}{1}", model, Environment.NewLine));

            output.Append(string.Format("Manufacturer: {0}{1}", manufacturer, Environment.NewLine));

            if (price != null)
            {
                output.Append(string.Format("Price: {0:C2}{1}", price, Environment.NewLine));
            }
            if (owner != null)
            {
                output.Append(string.Format("Owner: {0}{1}", owner, Environment.NewLine));
            }
            if (displayInformation != null && (displayInformation.DisplayHeight != null || displayInformation.NumberOfColors!=null))
            {
                output.Append(string.Format("Display: {1}{0}", displayInformation, Environment.NewLine));
            }
            if (batteryInformation != null)
            {
                output.Append(string.Format("Battery: {1}{0}", batteryInformation, Environment.NewLine));
            }

            return output.ToString();
        }
    }
}