using System;
using Students.Library;

namespace Students.Test
{
    class Test
    {
        static void Main()
        {
            Student pesho = new Student("Pesho", "Peshev", "Peshev", 1000000, "testemail@email.com", "088888888", 2,
                University.TechnicalUniversityOfSofia, Faculty.FacultyOfIndustrialTechnology, Speciality.IndustrialTechnology);

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Creating new student Pesho:");
            Console.WriteLine(pesho);

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Creating a clone of Pesho using .Clone():");
            Student peshoClone = (Student)pesho.Clone();
            Console.WriteLine(peshoClone);

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Creating a new student Ivan:");
            Student ivan = new Student("Ivan", "Georgiev", "Spasov", 1000001, "ivankyrti@email.com", "089988888", 4,
                University.SofiaUniversity, Faculty.FacultyOfLaw, Speciality.Law);
            Console.WriteLine(ivan);

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Creating a new student Alexander:");
            Student alexander = new Student("Alexander", "Petrov", "Alexandrov", 1005001, "alexftw@email.com", "089988777", 4,
                University.MedicalUniversitySofia, Faculty.FacultyOfDentalMedicine, Speciality.DentalMedicine);
            Console.WriteLine(alexander);

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Checking for equality of Pesho and his clone:");
            Console.WriteLine("Using == --> {0}", pesho == peshoClone);
            Console.WriteLine("Using != --> {0}", pesho != peshoClone);
            Console.WriteLine("Using .Equals() --> {0}", pesho.Equals(peshoClone));

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Checking for equality of Pesho and Ivan:");
            Console.WriteLine("Using == --> {0}", pesho == ivan);
            Console.WriteLine("Using != --> {0}", pesho != ivan);
            Console.WriteLine("Using .Equals() --> {0}", pesho.Equals(ivan));

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Comparing Pesho and Ivan using .CompareTo():");
            Console.WriteLine("Using .CompareTo() --> {0}", pesho.CompareTo(ivan));
            Console.WriteLine("Comparing Alexander and Ivan using .CompareTo():");
            Console.WriteLine("Using .CompareTo() --> {0}", alexander.CompareTo(ivan));
            Console.WriteLine("Comparing Pesho and Alexander using .CompareTo():");
            Console.WriteLine("Using .CompareTo() --> {0}", pesho.CompareTo(alexander));
            Console.WriteLine("Comparing Pesho and his clone using .CompareTo():");
            Console.WriteLine("Using .CompareTo() --> {0}", pesho.CompareTo(peshoClone));

            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Getting the hash codes of the students:");
            Console.WriteLine("Pesho --> {0}", pesho.GetHashCode());
            Console.WriteLine("Pesho's clone --> {0}", peshoClone.GetHashCode());
            Console.WriteLine("Ivan --> {0}", ivan.GetHashCode());
            Console.WriteLine("Alexander --> {0}", alexander.GetHashCode());


            //Errors
            Console.WriteLine(new String('*', 40));
            Console.WriteLine("Trying some exceptions:");
            try
            {
                Console.WriteLine("Using .Equals() on Pesho and an int with value of 5:");
                object number = 5;
                ivan.Equals(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Setting Pesho's name to null:");
                pesho.FirstName = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}