using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05_GreedyTimes
{
    public class Bag
    {
        public long Capacity { get; set; }
        public long Gold { get; set; }
        public List<Gem> Gems { get; set; }
        public List<Cash> Cash { get; set; }

        public Bag(long capacity)
        {
            Capacity = capacity;
            Gold = 0;
            Gems = new List<Gem>();
            Cash = new List<Cash>();
        }

        public void AddGold(long quantity)
        {
            if (IsEnoughSpace(quantity))
            {
                Gold += quantity;
            }
        }

        public void AddGem(string name, long quantity)
        {
            if (IsEnoughSpace(quantity) && Gold >= Gems.Sum(g => g.Quantity) + quantity)
            {
                Gem gem = Gems.FirstOrDefault(g => g.Name == name);
                if (gem == null)
                {
                    gem = new Gem(name);
                    Gems.Add(gem);
                }

                gem.Quantity += quantity;
            }
        }

        public void AddCash(string currency, long quantity)
        {
            if (IsEnoughSpace(quantity) && Gems.Sum(g => g.Quantity) >= Cash.Sum(c => c.Quantity) + quantity)
            {
                Cash cash = this.Cash.FirstOrDefault(c => c.Currency == currency);
                if (cash == null)
                {
                    cash = new Cash(currency);
                    this.Cash.Add(cash);
                }

                cash.Quantity += quantity;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<Gold> $" + Gold);
            sb.AppendLine("##Gold - " + Gold);
            var gemsTotal = Gems.Sum(g => g.Quantity);
            if (gemsTotal > 0)
            {
                sb.AppendLine("<Gem> $" + gemsTotal);
                foreach (var gem in Gems.OrderByDescending(g => g.Name).ThenBy(g => g.Quantity))
                {
                    sb.AppendLine($"##{gem.Name} - {gem.Quantity}");
                }

                var cashTotal = Cash.Sum(c => c.Quantity);
                if (cashTotal > 0)
                {
                    sb.AppendLine("<Cash> $" + cashTotal);
                    foreach (var cash in Cash.OrderByDescending(g => g.Currency).ThenBy(g => g.Quantity))
                    {
                        sb.AppendLine($"##{cash.Currency} - {cash.Quantity}");
                    }
                }
            }

            return sb.ToString();
        }

        private bool IsEnoughSpace( long quantity)
            => Capacity >= quantity + Gold + Gems.Sum(g => g.Quantity) + Cash.Sum(c => c.Quantity);
    }
}
