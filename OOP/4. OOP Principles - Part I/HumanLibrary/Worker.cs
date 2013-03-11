//Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. 
namespace HumanLibrary
{
    public class Worker : Human
    {
        public double WeekSalary { get; set; }
        public double WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            double moneyPerHour = (WeekSalary / 5) / WorkHoursPerDay;
            return moneyPerHour;
        }

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} | MPH: {2:F2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
