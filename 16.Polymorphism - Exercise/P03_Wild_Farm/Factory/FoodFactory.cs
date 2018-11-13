using System;
using WildFarm.Contracts;
using WildFarm.Models.Foods;

namespace WildFarm.Factory
{
    public class FoodFactory
    {
        public IFood CreateFood(string[] info)
        {
            var foodType = info[0].ToLower();
            var quantity = int.Parse(info[1]);

            switch (foodType)
            {
                case "vegetable":
                    return new Vegetable(quantity);
                case "fruit":
                    return new Fruit(quantity);
                case "meat":
                    return new Meat(quantity);
                case "seeds":
                    return new Seeds(quantity);
                default:
                    throw new ArgumentException("Invalid food type");
            }
        }
    }
}
