﻿using System;

namespace Farm.Factories
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string type, string name, int age, string gender)
        {
            switch (type)
            {
                case "dog":
                    return new Dog(name, age, gender);
                case "cat":
                    return new Cat(name, age, gender);
                case "frog":
                    return new Frog(name, age, gender);
                case "kitten":
                    return new Kitten(name, age);
                case "tomcat":
                    return new Tomcat(name, age);
                default:
                    throw new ArgumentException("Invalid input!");
            }
        }

    }
}
