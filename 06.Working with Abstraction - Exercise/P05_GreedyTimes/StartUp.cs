using System;

namespace P05_GreedyTimes
{
    public class StartUp
    {
        static Bag bag;
        static void Main(string[] args) // 50/100
        {
            int capacity = int.Parse(Console.ReadLine());
            bag = new Bag(capacity);
                        
            string[] treasure = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < treasure.Length; i += 2)
            {
                string name = treasure[i];
                int quantity = int.Parse(treasure[i + 1]);

                if (name.ToLower() == "gold")
                {
                    bag.AddGold(quantity);
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    bag.AddGem(name, quantity);
                }
                else if (name.Length == 3)
                {
                    bag.AddCash(name, quantity);
                }
            }

            Console.Write(bag);
        }
    }
}