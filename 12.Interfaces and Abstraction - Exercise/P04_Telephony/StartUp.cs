using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();

            var numbers = Console.ReadLine().Split();
            var sites = Console.ReadLine().Split();

            CallAll(numbers, phone);
            BrowseAll(sites, phone);
        }

        private static void BrowseAll(string[] sites, Phone phone)
        {
            foreach (var url in sites)
            {
                try
                {
                    Console.WriteLine(phone.Browse(url));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }

        private static void CallAll(string[] numbers, Phone phone)
        {
            foreach (var number in numbers)
            {
                try
                {
                    Console.WriteLine(phone.Call(number));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
