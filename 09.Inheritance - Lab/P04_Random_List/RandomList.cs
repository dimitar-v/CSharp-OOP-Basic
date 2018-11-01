using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();
            int i = random.Next(Count);
            string str = this[i];
            RemoveAt(i);
            return str;
        }
    }
}
