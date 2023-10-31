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
}
