//Both teachers and students are people
namespace School.Library
{
    public class Person : ICommentable
    {
        private string name;
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
