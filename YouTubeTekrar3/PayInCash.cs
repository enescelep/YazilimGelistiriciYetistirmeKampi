using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeTekrar3
{
    class PayInCash : IPaymentMethod
    {
        public void Pay(double Price)
        {
            Console.WriteLine("You have paid "+ Price + "TRY in cash.\nHave a nice day!");
        }
    }
}
