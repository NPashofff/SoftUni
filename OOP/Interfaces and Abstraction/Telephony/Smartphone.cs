using System;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICallble, IBrowsble
    {
        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidUrlExeption();
            }
            return $"Browsing: {url}!";
        }

        public string Call(string num)
        {
            if (!num.All(x => char.IsDigit(x)))
            {
                throw new InvalitdNumExeption();
            }
            return $"Calling... {num}";
        }
    }
}
