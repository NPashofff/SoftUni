using System.Linq;
using System;

namespace Telephony
{
    public class StationaryPhone : ICallble
    {
        public string Call(string num)
        {
            if (!num.All(x => char.IsDigit(x)))
            {
                throw new InvalitdNumExeption();
            }
            return $"Dialing... {num}";
        }
    }
}
