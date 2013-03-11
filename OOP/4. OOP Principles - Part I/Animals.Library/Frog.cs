namespace Animals.Library
{
    public class Frog : Animal
    {
        public Frog(string name, int age, Sex gender)
            : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Kvaak!");
        }
    }
}
