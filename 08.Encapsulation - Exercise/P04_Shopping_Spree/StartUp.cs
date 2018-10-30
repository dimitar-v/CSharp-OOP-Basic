using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> customers = new List<Person>();
            List<Product> products = new List<Product>();

            GetAll(customers);
            GetAll(products);
            
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var purchaseInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var person = customers.FirstOrDefault(p => p.Name == purchaseInfo[0]);
                var product = products.FirstOrDefault(p => p.Name == purchaseInfo[1]);

                if (person != null && product != null)
                {
                    Console.WriteLine(person.BuyingA(product));
                }
            }

            customers.ForEach(Console.WriteLine);
        }

        private static void GetAll(List<Product> products)
        {
            var productsInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var info in productsInfo)
            {
                var productInfo = info.Split('=');

                try
                {
                    Product product = new Product(productInfo[0], decimal.Parse(productInfo[1]));
                    products.Add(product);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    Environment.Exit(0);
                }
            }
        }

        private static void GetAll(List<Person> customers)
        {
            var personsInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var info in personsInfo)
            {
                var personInfo = info.Split('=');

                try
                {
                    Person person = new Person(personInfo[0], decimal.Parse(personInfo[1]));
                    customers.Add(person);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
