//Deposit accounts are allowed to deposit and with draw money. 
namespace Bank.Library
{
    using System;

    public class Deposit : Account, IWithdrawable
    {

        public void WithdrawMoney(decimal ammount)
        {
            if (ammount < 0)
            {
                throw new ArgumentOutOfRangeException("The withdrawn ammount cannot be negative.");
            }
            //Deposits balance cannot be negative
            if (ammount > this.balance)
            {
                throw new ArgumentOutOfRangeException("The withdrawn ammount cannot be more than the account balance.");
            }

            this.balance -= ammount;
        }

        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterestAmount(int period)
        {
            if (period <= 0)
            {
                throw new ArgumentException("The period cannot be negative or zero.");
            }

            //Deposit accounts have no interest if their balance is positive and less than 1000.
            if (this.Balance < 1000)
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