using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    class StackOfStrings
    {
        private List<string> data;

        public StackOfStrings()
        {
            data = new List<string>();
        }

        public void Push(string item)
            => data.Add(item);

        public string Pop()
        {
            EmptyException();
            var str = data.Last();
            data.RemoveAt(data.Count - 1);
            return str;
        }
               
        public string Peek()
        {
            EmptyException();
            return data.Last();
        }

        public bool IsEmpty()
            => data.Count == 0;

        private void EmptyException()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("The stack is empty");
            }
        }
    }
}
