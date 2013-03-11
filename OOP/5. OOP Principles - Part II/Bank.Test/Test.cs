using System;
using Bank.Library;

namespace Bank.Test
{
    class Test
    {
        static void Main()
        {
            Individual person = new Individual("Pesho", "Peshov", new DateTime(1986, 3, 3), 5555555, "Tryn", "088888888");
            Company corp = new Company("Kartofi OOD", "00222222222", "Tryn", "0888888888");

            Deposit personDeposit = new Deposit(person, 1500, 1.3M);
            Deposit compDeposit = new Deposit(corp, 1500, 1.3M);
            Loan personLoan = new Loan(person, 1500, 2.4M);
            Loan compLoan = new Loan(corp, 1500, 2.4M);
            Mortgage personMortgage = new Mortgage(person, 1500, 3M);
            Mortgage compMortgage = new Mortgage(corp, 1500, 3M);

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Calculating Deposit interest:");
            Console.WriteLine("Individual 24 months: {0:%#0.00}", personDeposit.CalculateInterestAmount(24));
            Console.WriteLine("Individual 12 months: {0:%#0.00}", personDeposit.CalculateInterestAmount(12));
            Console.WriteLine("Company 24 months: {0:%#0.00}", compDeposit.CalculateInterestAmount(24));
            Console.WriteLine("Company 12 months: {0:%#0.00}", compDeposit.CalculateInterestAmount(12));
            Console.WriteLine(new String('*',40));
            Console.WriteLine("Calculating Loan interest:");
            Console.WriteLine("Individual 3 months: {0:%#0.00}", personLoan.CalculateInterestAmount(3));
            Console.WriteLine("Individual 12 months: {0:%#0.00}", personLoan.CalculateInterestAmount(12));
            Console.WriteLine("Company 2 months: {0:%#0.00}", compLoan.CalculateInterestAmount(2));
            Console.WriteLine("Company 12 months: {0:%#0.00}", compLoan.CalculateInterestAmount(12));
            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Calculating Mortgage interest:");
            Console.WriteLine("Individual 6 months: {0:%#0.00}", personMortgage.CalculateInterestAmount(6));
            Console.WriteLine("Individual 24 months: {0:%#0.00}", personMortgage.CalculateInterestAmount(24));
            Console.WriteLine("Company 6 months: {0:%#0.00}", compMortgage.CalculateInterestAmount(3));
            Console.WriteLine("Company 24 months: {0:%#0.00}", compMortgage.CalculateInterestAmount(12));
        }
    }
}
