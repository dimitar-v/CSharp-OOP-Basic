using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }

        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                money = value;
            }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                name = value;
            }
        }

        public string BuyingA(Product product)
        {
            if (Money < product.Cost)
            {
                return $"{Name} can't afford {product.Name}";
            }

            Money -= product.Cost;
            bag.Add(product);

            return $"{Name} bought {product.Name}";
        }

        public override string ToString()
        {
            if (bag.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }

            return $"{Name} - {string.Join(", ", bag.Select(p => p.Name).ToArray())}";
        }
    }
}
