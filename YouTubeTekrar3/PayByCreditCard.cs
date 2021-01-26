using System;
using System.Collections.Generic;
using System.Text;

namespace YouTubeTekrar3
{
    class PayByCreditCard : IPaymentMethod
    {
        public void Pay(Product product)
        {
            Console.WriteLine("Enter your credit card infos,");
            Console.Write("Name-Surname:");
            string adSoyad = Convert.ToString(Console.ReadLine());
            Console.Write("Card Number:"); 
            string kartNumarasi = Convert.ToString(Console.ReadLine());
            Console.Write("Expiration Date:");
            string sonKullanmaTarihi = Convert.ToString(Console.ReadLine());
            Console.Write("Security code:");
            int cvc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have bought "+ product.Name+"\nYou have paid "+product.Price+"TRY by credit card.\nHave a nice day!\n");
        }
    }
}
