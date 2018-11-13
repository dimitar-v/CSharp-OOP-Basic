using WildFarm.Contracts;
using WildFarm.Models.Foods;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        private const double FOOD_INCREASE = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (!(food is Vegetable) && !(food is Meat))
            {
                WrongFoodException(food);
            }

            base.Eat(food, FOOD_INCREASE);
        }

        public override string AskFood()
            => "Meow";
    }
}
