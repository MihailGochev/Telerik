//Each teacher teaches a set of disciplines.
//Teachers have name.
namespace School.Library
{
    public class Teacher : Person
    {
        private Discipline[] disciplines;

        public Discipline[] Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }
    }
}
