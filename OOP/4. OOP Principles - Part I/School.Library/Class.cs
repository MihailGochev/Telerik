//In the school there are classes of students. Each class has a set of teachers. 
//Classes have unique text identifier. 
namespace School.Library
{
    public class Class : ICommentable
    {
        private string comment;
        private string identifier;
        private Student[] students;
        private Teacher[] teachers;

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }
            set
            {
                this.identifier = value;
            }
        }

        public Student[] Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public Teacher[] Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }
    }
}
