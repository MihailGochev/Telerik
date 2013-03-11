//Kittens and tomcats are cats. Kittens can be only female and tomcats can be only male. 
namespace Animals.Library
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Sex.Male)
        {
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("MEEEEEEOW!");
        }
    }
}