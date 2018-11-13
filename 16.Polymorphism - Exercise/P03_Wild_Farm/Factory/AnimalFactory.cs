using System;
using WildFarm.Models;

namespace WildFarm.Factory
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string[] info)
        {
            var type = info[0];
            var name = info[1];
            var weight = double.Parse(info[2]);
            double wingSize;
            string livingRegion = info[3];
            string breed = info.Length > 4 ? info[4] : "";

            switch (type)
            {
                case "Owl":
                    wingSize = double.Parse(info[3]);
                    return new Owl(name, weight, wingSize);
                case "Hen":
                    wingSize = double.Parse(info[3]);
                    return new Hen(name, weight, wingSize);
                case "Mouse":
                    return new Mouse(name, weight, livingRegion);
                case "Dog":
                    return new Dog(name, weight, livingRegion);
                case "Cat":
                    return new Cat(name, weight, livingRegion, breed);
                case "Tiger":
                    return new Tiger(name, weight, livingRegion, breed);
                default:
                    throw new ArgumentException("Invalid animal type");
            }
        }
    }
}
