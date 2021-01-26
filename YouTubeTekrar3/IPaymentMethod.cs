using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeTekrar3
{
    interface IPaymentMethod
    {
        void Pay(Product product);
    }
}
