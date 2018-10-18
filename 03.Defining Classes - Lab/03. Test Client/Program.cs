using System;
using System.Collections.Generic;

namespace BancAccount
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var accs = new Dictionary<int, BankAccount>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var id = int.Parse(commands[1]);
                
                switch (commands[0])
                {
                    case "Create":
                        Create(accs, id);
                        break;
                    case "Deposit":
                        Deposit(accs, id, decimal.Parse(commands[2]));
                        break;
                    case "Withdraw":
                        Withdraw(accs, id, decimal.Parse(commands[2]));
                        break;
                    case "Print":
                        Print(accs, id);
                        break;
                }
            }
        }

        private static void Print(Dictionary<int, BankAccount> accs, int id)
        {
            if (!accs.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            Console.WriteLine(accs[id]);
        }

        private static void Withdraw(Dictionary<int, BankAccount> accs, int id, decimal amound)
        {
            if (!accs.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            if (accs[id].Balance < amound)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }

            accs[id].Balance -= amound;
        }

        private static void Deposit(Dictionary<int, BankAccount> accs, int id, decimal amound)
        {
            if (!accs.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            accs[id].Balance += amound;
        }

        private static void Create(Dictionary<int, BankAccount> accs, int id)
        {
            if (accs.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
                return;
            }
            
            accs[id] = new BankAccount();
            accs[id].Id = id;
            accs[id].Balance = 0;          
        }
    }
}
