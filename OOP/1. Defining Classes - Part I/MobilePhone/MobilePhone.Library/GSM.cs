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

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public decimal Price
        {
            get
            {
                return price.GetValueOrDefault();
            }
            set { price = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public Battery BatteryInformation
        {
            get { return batteryInformation; }
            set { batteryInformation = value; }
        }

        public Display DisplayInformation
        {
            get { return displayInformation; }
            set { displayInformation = value; }
        }

        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
            this.displayInformation = null;
            this.batteryInformation = null;
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = null;
            this.displayInformation = null;
            this.batteryInformation = null;
        }

        public GSM(string model, string manufacturer, Display displayInformation, Battery batteryInformation)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = null;
            this.owner = null;
            this.displayInformation = displayInformation;
            this.batteryInformation = batteryInformation;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Display displayInformation, Battery batteryInformation)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.displayInformation = displayInformation;
            this.batteryInformation = batteryInformation;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append(string.Format("Model: {0}{1}", model, Environment.NewLine));

            output.Append(string.Format("Manufacturer: {0}{1}", manufacturer, Environment.NewLine));

            if (price != null)
            {
                output.Append(string.Format("Price: {0}{1}", price, Environment.NewLine));
            }
            if (owner != null)
            {
                output.Append(string.Format("Owner: {0}{1}", owner, Environment.NewLine));
            }
            if (displayInformation != null)
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