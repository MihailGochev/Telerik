//Loan and mortgage accounts can only deposit money.
namespace Bank.Library
{
    using System;

    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int period)
        {

            if (this.Customer.Type == CustomerType.Individual)
            {
                if (period <= 12)
                {
                    return CalculateInterest(this.interestRate / 2, period);
                }
                else
                //Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
                {
                    decimal currentInterestRate = CalculateInterest(this.interestRate / 2, 12);
                    return currentInterestRate * CalculateInterest(this.interestRate, period - 12);
                }
            }
            else //Company
            {
                if (period <= 6)
                {
                    return 0;
                }
                else
                {
                    return CalculateInterest(this.interestRate, period - 6);
                }
            }
        }
    }
}