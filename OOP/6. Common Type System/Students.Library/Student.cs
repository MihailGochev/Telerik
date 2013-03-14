//Define a class Student, which contains data about a student – first, middle and last name, SSN, 
//permanent address, mobile phone e-mail, course, specialty, university, faculty.
namespace Students.Library
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string email;
        private string phone;
        private byte course;
        private University university;
        private Faculty faculty;
        private Speciality speciality;

        #region Properties

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty.");
                }
                firstName = value;
            }
        }

        public string MiddleName
        {
            get { return middleName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty.");
                } 
                middleName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty.");
                } 
                lastName = value;
            }
        }

        public int Ssn
        {
            get { return ssn; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The SSN cannot be negative or zero.");
                }
                ssn = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The email cannot be null or empty.");
                }
                email = value;
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The phone number cannot be null or empty.");
                }
                phone = value;
            }
        }

        public byte Course
        {
            get { return course; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The course cannot be negative.");
                }
                course = value;
            }
        }


        public University University
        {
            get { return university; }
            set { university = value; }

        }

        public Faculty Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public Speciality Speciality
        {
            get { return speciality; }
            set { speciality = value; }

        }
        #endregion

        public Student(string firstName,
            string middleName, string lastName,
            int ssn, string email, string phone,
            byte course, University university,
            Faculty faculty, Speciality speciality)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.Email = email;
            this.Phone = phone;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Speciality = speciality;
        }

        //Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
        public override bool Equals(object obj)
        {
            if (obj is Student)
            {
                Student student = (Student)obj;
                if (this.FirstName == student.firstName &&
                    this.MiddleName == student.middleName &&
                    this.LastName == lastName &&
                    this.Ssn == student.ssn &&
                    this.Email == student.email &&
                    this.Phone == student.phone &&
                    this.Course == student.course &&
                    this.University == student.university &&
                    this.Faculty == student.faculty &&
                    this.Speciality == student.speciality)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new ArgumentException(String.Format("The object is of type {0}, not Student.", obj.GetType().Name));
            }
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^
                LastName.GetHashCode() ^ Ssn.GetHashCode() ^ Email.GetHashCode() ^
                Phone.GetHashCode() ^ Course.GetHashCode() ^ University.GetHashCode() ^
                Faculty.GetHashCode() ^ Speciality.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(String.Format("Name: {0} {1} {2}{3}", firstName, middleName, LastName, Environment.NewLine));
            output.Append(String.Format("SSN: {0}{1}", ssn, Environment.NewLine));
            output.Append(String.Format("Email: {0}{1}", Email, Environment.NewLine));
            output.Append(String.Format("Phone: {0}{1}", Phone, Environment.NewLine));
            output.Append(String.Format("University: {0}{1}", University, Environment.NewLine));
            output.Append(String.Format("Faculty: {0}{1}", Faculty, Environment.NewLine));
            output.Append(String.Format("Speciality: {0}", Speciality));
            return output.ToString();
        }

        public static bool operator ==(Student student, Student student2)
        {
            return student.Equals(student2);
        }

        public static bool operator !=(Student student, Student student2)
        {
            return !student.Equals(student2);
        }

        //Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        //Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
        //and by social security number (as second criteria, in increasing order).
        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else if (this.LastName != other.LastName)
            {
                return this.FirstName.CompareTo(other.LastName);
            }
            else if (this.Ssn != other.Ssn)
            {
                return this.FirstName.CompareTo(other.Ssn);
            }
            else
            {
                return 0;
            }
        }
    }
}
