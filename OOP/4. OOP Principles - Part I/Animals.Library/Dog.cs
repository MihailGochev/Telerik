namespace Animals.Library
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Sex gender)
            : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Woof!");
        }
    }
}
