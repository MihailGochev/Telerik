namespace HumanLibrary
{
    public class Student : Human
    {
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} | Grade:{2}", FirstName, LastName, Grade);
        }
    }
}
