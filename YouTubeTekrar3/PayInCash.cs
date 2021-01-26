using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeTekrar3
{
    class PayInCash : IPaymentMethod
    {
        public void Pay(Product product)
        {
            Console.WriteLine("You have bought " + product.Name + "\nYou have paid " + product.Price + "TRY by credit card.\nHave a nice day!\n");
        }
    }
}
