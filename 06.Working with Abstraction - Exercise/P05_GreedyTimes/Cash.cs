namespace P05_GreedyTimes
{
    public class Cash
    {
        public string Currency { get; set; }
        public long Quantity { get; set; }

        public Cash(string currency)
        {
            Currency = currency;
            Quantity = 0;
        }

        public Cash(string currency, int quantity)
            :this(currency)
        { 
            Quantity = quantity;
        }
    }
}
