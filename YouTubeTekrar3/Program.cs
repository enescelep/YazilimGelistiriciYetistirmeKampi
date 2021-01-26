using System;

namespace YouTubeTekrar3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Name = "Chair",
                Description = "Single white chair",
                Price = 159.90
            };

            Product product2 = new Product
            {
                Name = "Table",
                Description = "Dining Table",
                Price = 67.90,
            };

            IPaymentMethod card = new PayByCreditCard();
            IPaymentMethod cash = new PayInCash();
            card.Pay(product1.Price);
            cash.Pay(product2.Price);
        }
    }
}
