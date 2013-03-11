//Customers could be individuals or companies.
namespace Bank.Library
{
    using System;
    public abstract class Customer
    {
        private string address;
        private string phoneNumber;
        private CustomerType type;

        public string Address
        {
            get { return address; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The address cannot be empty or null.");
                }
                address = value;
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The phone number cannot be empty or null.");
                }
                phoneNumber = value;
            }
        }

        public CustomerType Type
        {
            get { return type; }
            private set { type = value; }
        }

        public Customer(string address, string phoneNumber, CustomerType type)
        {
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Type = type;
        }
    }
}
