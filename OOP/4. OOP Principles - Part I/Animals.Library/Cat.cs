namespace Animals.Library
{
    public class Cat : Animal
    {
        public Cat(string name, int age, Sex gender)
            : base(name, age, gender)
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Meow!");
        }
    }
}
