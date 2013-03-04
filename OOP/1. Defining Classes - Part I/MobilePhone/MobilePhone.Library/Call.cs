//Create a class Call to hold a call performed through a GSM. 
//It should contain date, time, dialed phone number and duration (in seconds).
//Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
//Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
//Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.

namespace MobilePhone.Library
{
    using System;

    public class Call : IComparable
    {
        private DateTime callTime;
        private string dialedNumber;
        private int durationInSeconds;

        //Used to find longest/shortest call
        public int CompareTo(object obj)
        {
            if (((Call)obj).durationInSeconds > this.durationInSeconds)
            {
                return -1;
            }
            else if (((Call)obj).durationInSeconds == this.durationInSeconds)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public DateTime CallTime
        {
            get { return callTime; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Call time cannot be null!");
                }
                callTime = value;
            }
        }

        public string DialedNumber
        {
            get { return dialedNumber; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("The number cannot be null!");
                }

                if (value == String.Empty)
                {
                    throw new ArgumentException("Empty number!");
                }
                dialedNumber = value;
            }
        }

        public int Duration
        {
            get { return durationInSeconds; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Duration cannot be null!");
                }

                if (value <= 0)
                {
                    throw new ArgumentException("Duration cannot be negative!");
                }

                durationInSeconds = value;
            }
        }

        public Call(string dialedNumber, DateTime callTime, int durationInSeconds)
        {
            if (callTime == null)
            {
                throw new NullReferenceException("Call time cannot be null!");
            }

            if (dialedNumber == null)
            {
                throw new NullReferenceException("The number cannot be null!");
            }

            if (dialedNumber == String.Empty)
            {
                throw new ArgumentException("Empty number!");
            }

            if (durationInSeconds == null)
            {
                throw new NullReferenceException("Duration cannot be null!");
            }

            if (durationInSeconds <= 0)
            {
                throw new ArgumentException("Duration cannot be negative!");
            }


            this.callTime = callTime;
            this.dialedNumber = dialedNumber;
            this.durationInSeconds = durationInSeconds;
        }

        public override string ToString()
        {
            return String.Format("Called number:{0} | started: {1} | ended:{2} | duration:{3}", dialedNumber, callTime, callTime.AddSeconds(durationInSeconds), durationInSeconds);
        }
    }
}
