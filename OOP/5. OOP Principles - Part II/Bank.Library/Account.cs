//All accounts have customer, balance and interest rate (monthly based). 
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
namespace Bank.Library
{
    using System;

    public abstract class Account : IDepositable
    {
        protected Customer customer;
        protected decimal balance;
        protected decimal interestRate;

        public Customer Customer
        {
            get { return customer; }
            private set
            {
                if (value == null)
                {
                    throw new NullReferenceException("The customer cannot be null.");
                }
                customer = value;
            }
        }

        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The balance cannot be negative.");
                }
                balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return interestRate; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The interest rate cannot be negative.");
                }
                interestRate = value;
            }
        }

        abstract public decimal CalculateInterestAmount(int period);

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        //Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money. --> All accounts can deposit money
        public void DepositMoney(decimal ammount)
        {
            if (ammount < 0)
            {
                throw new ArgumentOutOfRangeException("The deposited ammount cannot be negative.");
            }

            this.balance += ammount;
        }

        //used to calculate interest ammount
        protected decimal CalculateInterest(decimal number, int months)
        {
            number = number / 100 + 1; //to handle percentage
            decimal result = 1;
            for (int power = 0; power < months; power++)
            {
                result *= number;
            }
            return result;
        }
    }
}
