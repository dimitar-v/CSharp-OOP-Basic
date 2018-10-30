using System;

namespace Pizza_Calories
{
    class StartUp // 78 / 100
    {
        static void Main(string[] args)
        {
            Pizza pizza = null;

            GetPizza(ref pizza);
            pizza.Dough = GetDough();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                pizza.AddTopping(GetTopping(input));
            }

            Console.WriteLine(pizza);
        }

        private static Topping GetTopping(string[] input)
        {
            Topping topping = null;
            try
            {
                topping = new Topping(input[1], int.Parse(input[2]));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                Environment.Exit(0);
            }

            return topping;
        }

        private static Dough GetDough()
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            Dough dough = null;
            try
            {
                dough = new Dough(int.Parse(input[3]), input[1], input[2]);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                Environment.Exit(0);
            }

            return dough;
        }

        private static void GetPizza(ref Pizza pizza)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            try
            {
                pizza = new Pizza(input[1]);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                Environment.Exit(0);
            }
        }
    }
}
