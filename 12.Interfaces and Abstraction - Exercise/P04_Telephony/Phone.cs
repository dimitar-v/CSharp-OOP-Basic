using System;
using System.Linq;

namespace Telephony
{
    public class Phone : ICall, IBrowse
    { 
        public string Browse(string url)
        {
            IsUrl(url);
            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            IsNumber(number);
            return $"Calling... {number}";
        }

        private void IsNumber(string number)
        {
            if (!number.All(char.IsDigit))
            {
                throw new ArgumentException("Invalid number!");
            }
        }

        private void IsUrl(string url)
        {
            if (url.Any(char.IsDigit))
            {
                throw new ArgumentException("Invalid URL!");
            }
        }


    }
}
