using System;

namespace ObjectOrientedProgrammingIntroduction
{
    class Student
    {
        private string Name;
        private string LastName;
        private int Age;

        public Student(string name, string lastName, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name cannot be empty");
            
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentNullException("LastName cannot be empty");

            if (age < 16)
                throw new ArgumentNullException("Student need to be not less than 16");

            Name = name;
            LastName = lastName;
            Age = age;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int newAge)
        {
            if (newAge < 16)
                throw new ArgumentNullException("Student need to be not less than 16");
            Age = newAge;
        }

        public void SetLastName(string newLastName)
        {
            if (string.IsNullOrWhiteSpace(newLastName))
                throw new ArgumentNullException("LastName cannot be empty");
            LastName = newLastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("John", "Smith", 20);
            
            Console.WriteLine($"{s1.GetName()} {s1.GetLastName()} is {s1.GetAge()} years old");

            s1.SetAge(21);
            Console.WriteLine($"{s1.GetName()} {s1.GetLastName()} is {s1.GetAge()} years old");
            
            s1.SetLastName("Bond");
            Console.WriteLine($"{s1.GetName()} {s1.GetLastName()} is {s1.GetAge()} years old");
        }
    }
}
