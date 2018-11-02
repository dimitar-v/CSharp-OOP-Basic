using System;
using System.Linq;

namespace P03_Mankind
{
    class Student : Human
    {
        private const int NUMBER_MIN_LENGTH = 5;
        private const int NUMBER_MAX_LENGTH = 10;

        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => facultyNumber;
            set
            {
                if (value.Length < NUMBER_MIN_LENGTH 
                    || value.Length > NUMBER_MAX_LENGTH 
                    || !value.All(Char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                facultyNumber = value;
            }
        }

        public override string ToString()
            => base.ToString() + $"Faculty number: {FacultyNumber}";
    }
}
