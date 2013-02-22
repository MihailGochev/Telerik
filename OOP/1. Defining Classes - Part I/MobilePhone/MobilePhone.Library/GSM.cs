//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics
//(model, hours idle and hours talk) and display characteristics (size and number of colors). 
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

using System;

namespace MobilePhone.Library
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
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
            get { return price; }
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
    }
}
