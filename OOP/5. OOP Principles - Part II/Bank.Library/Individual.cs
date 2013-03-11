namespace Bank.Library
{
    using System;

    public class Individual : Customer
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private int idCardNumber;

        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be empty or null.");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be empty or null.");
                }
                lastName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            private set
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentException("Invalid year of birth: less than 1900.");
                }
                if (value > DateTime.Now.AddYears(-18))
                {
                    throw new ArgumentException("The customer is not a major.");
                }
                dateOfBirth = value;
            }
        }

        public int IdCardNumber
        {
            get { return idCardNumber; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The ID card number cannot be negative.");
                }
                idCardNumber = value;
            }
        }

        public Individual(string firstName, string lastName, DateTime dateOfBirth, int idCardNumber, string address, string phoneNumber)
            : base(address, phoneNumber, CustomerType.Individual)
        {
            this.FirstName = firstName;
            this.lastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.IdCardNumber = idCardNumber;
        }
    }
}
