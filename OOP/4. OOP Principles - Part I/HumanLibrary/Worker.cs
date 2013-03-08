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
    }
}
