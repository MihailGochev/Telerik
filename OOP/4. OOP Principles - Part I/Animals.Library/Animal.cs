//All animals can produce sound (specified by the ISound interface). 
//All animals are described by age, name and sex.
namespace Animals.Library
{
    public abstract class Animal : ISound
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Sex Gender { get; set; }

        public Animal(string name, int age, Sex gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        abstract public void MakeSound();

        public override string ToString()
        {
            return string.Format("{0}: A {1} {2}, {3}", this.Name, this.Gender, this.GetType().Name, string.Format(this.Age == 1 ? "1 year old" : "{0} years old",this.Age));
        }
    }
}