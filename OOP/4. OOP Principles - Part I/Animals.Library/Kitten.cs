//Kittens and tomcats are cats. Kittens can be only female and tomcats can be only male. 
namespace Animals.Library
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Sex.Female)
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Mrrr!");
        }
    }
}