using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            stack.Push("str0");
            stack.Push("str1");
            stack.Push("str2");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
        }
    }
}
