using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class InvalitdNumExeption : Exception
    {
        public const string exMesage = "Invalid number!";
        public InvalitdNumExeption()
            : base(exMesage)
        {

        }
    }
}
