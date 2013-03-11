//Loan and mortgage accounts can only deposit money.
namespace Bank.Library
{
    using System;

    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int period)
        {
            if (period <= 0)
            {
                throw new ArgumentException("The period cannot be negative or zero.");
            }

            //Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
            if ((this.Customer.Type == CustomerType.Individual && period <= 3) || (this.Customer.Type == CustomerType.Company && period <= 2))
            {
                return 0;
            }
            else
            {
                return CalculateInterest(this.interestRate, period);
            }

        }
    }
}