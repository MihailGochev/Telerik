//Students have name and unique class number.
namespace School.Library
{
    public class Student : Person
    {
        private int classNumber;

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }
    }
}
