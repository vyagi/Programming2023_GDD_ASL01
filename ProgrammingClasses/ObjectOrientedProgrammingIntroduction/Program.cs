using System;

namespace ObjectOrientedProgrammingIntroduction
{
    public class Student 
    {
        private string _name;
        private string _lastName;
        private int _age;

        public Student(string name, string lastName, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name cannot be empty");

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentNullException("LastName cannot be empty");

            if (age < 16)
                throw new ArgumentNullException("Student need to be not less than 16");

            _name = name;
            _lastName = lastName;
            _age = age;
        }

        public string FirstName => _name;
        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("LastName cannot be empty");

                _lastName = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 16)
                    throw new ArgumentNullException("Student need to be not less than 16");
                _age = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Java style
            //OldSchoolStudent s1 = new OldSchoolStudent("John", "Smith", 20);

            //Console.WriteLine($"{s1.GetName()} {s1.GetLastName()} is {s1.GetAge()} years old");

            //s1.SetAge(21);
            //Console.WriteLine($"{s1.GetName()} {s1.GetLastName()} is {s1.GetAge()} years old");

            //s1.SetLastName("Bond");
            //Console.WriteLine($"{s1.GetName()} {s1.GetLastName()} is {s1.GetAge()} years old");

            //C# style
            Student s1 = new Student("John", "Smith", 20);
            s1.LastName = "Bond";
            s1.Age = 18;
            Console.WriteLine($"{s1.FirstName} {s1.LastName} is {s1.Age} years old");
        }
    }
}
