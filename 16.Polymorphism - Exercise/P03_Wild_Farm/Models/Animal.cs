using System;
using WildFarm.Contracts;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract void Eat(IFood food);

        public virtual void Eat(IFood food, double foodIncrease)
        {
            Weight += food.Quantity * foodIncrease;
            FoodEaten += food.Quantity;
        }

        public abstract string AskFood();

        protected string WrongFoodException(IFood food)
            => throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");

        public override string ToString()
            => $"{GetType().Name} [{Name}, ";
    }
}
