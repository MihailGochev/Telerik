//Disciplines have name, number of lectures and number of exercises.
namespace School.Library
{
    public class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExcersises;
        private string comment;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExcersises
        {
            get
            {
                return this.numberOfExcersises;
            }
            set
            {
                this.numberOfExcersises = value;
            }
        }

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
    }
}
