//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics
//(model, hours idle and hours talk) and display characteristics (size and number of colors). 
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

namespace MobilePhone.Library
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Display displayInformation;
        private Battery batteryInformation;
        private readonly List<Call> callHistory = new List<Call>();

        //Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
        static public GSM IPhone4S = new GSM("IPhone4S", "Apple", 1500M, new Display(640, 960, 16000000), new Battery("LIS1445APPC", 200, 14, BatteryType.LiPol));

        #region Properties
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
        #endregion

        #region Constructors
        public GSM(string model, string manufacturer)
        {
            this.Model = model; //setting the property
            this.Manufacturer = manufacturer; //setting the property
            this.price = null; //setting the field
            this.owner = null; //setting the field
            this.displayInformation = null; //setting the field
            this.batteryInformation = null; //setting the field
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer)
        {

            this.Price = price; //setting the property
            this.Owner = owner; //setting the property

        }

        public GSM(string model, string manufacturer, Display displayInformation, Battery batteryInformation)
            : this(model, manufacturer)
        {

            this.DisplayInformation = displayInformation; //setting the property
            this.BatteryInformation = batteryInformation; //setting the property
        }


        public GSM(string model, string manufacturer, decimal price, Display displayInformation, Battery batteryInformation)
            : this(model, manufacturer, displayInformation, batteryInformation)
        {

            this.Price = price; //setting the property
            this.owner = null; //setting the field
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Display displayInformation, Battery batteryInformation)
            : this(model, manufacturer, price, displayInformation, batteryInformation)
        {
            this.Owner = owner; //setting the property
        }
        #endregion

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
            if (displayInformation != null && (displayInformation.DisplayHeight != null || displayInformation.NumberOfColors != null))
            {
                output.Append(string.Format("Display: {1}{0}", displayInformation, Environment.NewLine));
            }
            if (batteryInformation != null)
            {
                output.Append(string.Format("Battery: {1}{0}", batteryInformation, Environment.NewLine));
            }

            return output.ToString();
        }

        //Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
        public void AddCall(string dialedNumber, DateTime callStart, int duration)
        {
            callHistory.Add(new Call(dialedNumber, callStart, duration));
        }

        //Deletes a specific call
        public void DeleteCall(Call deletedCall)
        {
            callHistory.Remove(deletedCall);
        }

        //Deletes a call at given position
        public void DeleteCall(int position)
        {
            if (position < 0 || position >= callHistory.Count)
            {
                throw new ArgumentException("Invalid call position!");
            }

            callHistory.RemoveAt(position);
        }

        //Deletes the longest call
        public void DeleteLongestCall()
        {
            callHistory.Remove(callHistory.Max());
        }

        //Deletes the shortest call
        public void DeleteShortestCall()
        {
            callHistory.Remove(callHistory.Min());
        }

        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        public string ShowCallHistory()
        {
            if (callHistory.Count == 0)
            {
                return "The call history is empty!";
            }
            StringBuilder callHistoryString = new StringBuilder();

            foreach (Call call in callHistory)
            {
                callHistoryString.Append(String.Format("{0}{1}", call.ToString(), Environment.NewLine));
            }

            return callHistoryString.ToString();
        }

        //Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.
        public decimal TotalCallPrice(decimal callPrice)
        {
            decimal totalDuration = 0;

            foreach (var call in callHistory)
            {
                totalDuration += call.Duration;
            }

            return (totalDuration / 60) * callPrice;
        }
    }
}