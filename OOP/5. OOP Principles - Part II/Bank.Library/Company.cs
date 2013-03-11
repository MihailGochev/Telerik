namespace Bank.Library
{
    using System;
    public class Company : Customer
    {
        private string companyName;
        private string faxNumber;

        public string CompanyName
        {
            get { return companyName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The company name cannot be empty or null.");
                } companyName = value;
            }
        }

        public string FaxNumber
        {
            get { return faxNumber; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The fax number cannot be empty or null.");
                }
                faxNumber = value;
            }
        }

        public Company(string companyName, string faxNumber, string address, string phoneNumber)
            : base(address, phoneNumber, CustomerType.Company)
        {
            this.CompanyName = companyName;
            this.FaxNumber = faxNumber;
        }
    }
}
