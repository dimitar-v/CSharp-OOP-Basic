using WildFarm.Contracts;
using WildFarm.Models.Foods;

namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        private const double FOOD_INCREASE = 0.10;

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(IFood food)
        {
            if (!(food is Vegetable) && !(food is Fruit))
            {
                WrongFoodException(food);
            }

            base.Eat(food, FOOD_INCREASE);
        }

        public override string AskFood()
            => "Squeak";
    }
}
