//Create a class Call to hold a call performed through a GSM. 
//It should contain date, time, dialed phone number and duration (in seconds).
//Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
//Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
//Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.

namespace MobilePhone.Library
{
    using System;

    class Call
    {
        private DateTime callTime;
        private string dialedNumber;
        private int duration;

        public DateTime CallTime
        {
            get { return callTime; }
            set { callTime = value; }
        }

        public String DialedNumber
        {
            get { return dialedNumber; }
            set { dialedNumber = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public Call(DateTime callTime,string dialedNumber,int duration)
        {

        }
    }
}
