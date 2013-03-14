//Create a class Person with two fields – name and age. 
//Age can be left unspecified (may contain null value. 
//Override ToString() to display the information of a person and if age is not specified – to say so. 
namespace PersonClass
{
    using System;
    public class Person
    {
        private string name;
        private byte? age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public byte? Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person() :
            this(null, null)
        {
        }

        public Person(byte? age) :
            this(null, age)
        {
        }

        public Person(string name) :
            this(name, null)
        {
        }
        public Person(string name, byte? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return String.Format("Person:{0}Name: {1}{0}Age: {2}{0}", Environment.NewLine, this.Name ?? "Undefined", this.Age != null ? this.Age.ToString() : "Undefined");
        }
    }
}
