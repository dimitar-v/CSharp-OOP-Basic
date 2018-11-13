using WildFarm.Contracts;
using WildFarm.Models.Foods;

namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        private const double FOOD_INCREASE = 0.40;

        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
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
            => "Woof!";
    }
}
