using System;

namespace Pizza_Calories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var input = Console.ReadLine().Split(' ');
                Pizza pizza = new Pizza(input[1]);
                input = Console.ReadLine().Split(' ');
                pizza.Dough = new Dough(int.Parse(input[3]), input[1], input[2]);

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    input = command.Split(' ');
                    
                    pizza.AddTopping(new Topping(input[1], int.Parse(input[2])));
                }

                Console.WriteLine(pizza);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}

