using WildFarm.Contracts;
using WildFarm.Models.Foods;

namespace WildFarm.Models
{
    public class Owl : Bird
    {
        private const double FOOD_INCREASE = 0.25;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            if (!(food is Meat))
            { 
                WrongFoodException(food);
            }

            base.Eat(food, FOOD_INCREASE);
        }

        public override string AskFood()
            => "Hoot Hoot";
    }
}
