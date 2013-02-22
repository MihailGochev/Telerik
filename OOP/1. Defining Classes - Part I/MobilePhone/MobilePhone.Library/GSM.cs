//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics
//(model, hours idle and hours talk) and display characteristics (size and number of colors). 
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

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

        public GSM()
        {
            this.model = "3310";
            this.manufacturer = "Nokia";
            this.price = 15M;
            this.owner = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.displayInformation = new Display();
            this.batteryInformation = new Battery();
        }

        public GSM(decimal price)
        {
            this.model = "3310";
            this.manufacturer = "Nokia"; 
            this.price = price;
            this.owner = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.displayInformation = new Display();
            this.batteryInformation = new Battery();
        }

        public GSM(Display displayInformation, Battery batteryInformation)
        {
            this.model = "3310";
            this.manufacturer = "Nokia";
            this.price = 15M;
            this.owner = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.displayInformation = displayInformation;
            this.batteryInformation = batteryInformation;
        }

        public GSM(string model, string manufacturer, decimal price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.displayInformation = new Display();
            this.batteryInformation = new Battery();
        }

        public GSM(string model, Display displayInformation, Battery batteryInformation)
        {
            this.model = model;
            this.manufacturer = "Nokia";
            this.price = 15M;
            this.owner = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.displayInformation = displayInformation;
            this.batteryInformation = batteryInformation;
        }

        public GSM(string model, string manufacturer, Display displayInformation, Battery batteryInformation)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = 15M;
            this.owner = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
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
    }
}