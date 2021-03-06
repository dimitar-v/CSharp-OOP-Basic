﻿using System;

namespace Farm
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value.Length < 1)
                {
                    InvalidInput();
                }
                name = value;
            }
        }

        public int Age
        {
            get => age;
            private set
            {
                if (value < 0)
                {
                    InvalidInput();
                }
                age = value;
            }
        }

        public string Gender
        {
            get => gender;
            private set
            {
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    InvalidInput();
                }
                gender = value;
            }
        }

        public object InvalidInput()
            => throw new ArgumentException("Invalid input!");

        public virtual string ProduceSound()
            => string.Empty;

        public override string ToString()
            => $"{this.GetType().Name}{Environment.NewLine}"
             + $"{Name} {Age} {Gender}{Environment.NewLine}"
             + $"{ProduceSound()}";
    }
}
