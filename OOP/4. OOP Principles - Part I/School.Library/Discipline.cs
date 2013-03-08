namespace School.Library
{
    public class Discipline : ICommentable
    {
        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExcersises { get; set; }
        public string Comment { get; set; }
    }
}
