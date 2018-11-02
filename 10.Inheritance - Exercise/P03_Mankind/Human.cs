using System;

namespace P03_Mankind
{
    class Human
    {
        private const int FIRSTNAME_MIN_LENGTH = 4;
        private const int LASTNAME_MIN_LENGTH = 3;

        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                ValidateName(value, FIRSTNAME_MIN_LENGTH, nameof(firstName));
                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                ValidateName(value, LASTNAME_MIN_LENGTH, nameof(lastName));
                lastName = value;
            }
        }

        private void ValidateName(string name, int minLength, string argName)
        {
            if (!char.IsUpper(name[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {argName}");
            }

            if (name.Length < minLength)
            {
                throw new ArgumentException($"Expected length at least {minLength} symbols! Argument: {argName}");
            }
        }

        public override string ToString()
            => $"First Name: {FirstName}{Environment.NewLine}Last Name: {LastName}{Environment.NewLine}";
    }
}
