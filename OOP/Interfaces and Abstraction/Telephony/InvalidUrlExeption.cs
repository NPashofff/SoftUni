using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    class InvalidUrlExeption : Exception
    {
        public const string exMesage = "Invalid URL!";
        public InvalidUrlExeption()
            : base(exMesage)
        {

        }
    }
}
