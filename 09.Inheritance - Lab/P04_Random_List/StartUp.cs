using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();

            list.Add("str0");
            list.Add("str1");
            list.Add("str2");
            list.Add("str3");
            list.Add("str4");
            list.Add("str5");
            list.Add("str6");
            list.Add("str7");
            list.Add("str8");
            list.Add("str9");
            list.Add("str10");
            list.Add("str11");

            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
            Console.WriteLine(list.RandomString());
        }
    }
}
