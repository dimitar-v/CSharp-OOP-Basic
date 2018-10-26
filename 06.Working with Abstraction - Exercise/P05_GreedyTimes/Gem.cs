namespace P05_GreedyTimes
{
    public class Gem
    {
        public string Name { get; set; }
        public long Quantity { get; set; }

        public Gem(string name)
        {
            Name = name;
            Quantity = 0;
        }

        public Gem(string name, int quantity)
            :this(name)
        {
            Quantity = quantity;
        }
    }
}
