using WildFarm.Contracts;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        private const double FOOD_INCREASE = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            base.Eat(food, FOOD_INCREASE);
        }

        public override string AskFood()
            => "Cluck";
    }
}
