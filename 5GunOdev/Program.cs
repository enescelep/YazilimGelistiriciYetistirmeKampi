using System;
using _5GunOdev.Entities;
using _5GunOdev.Adapter;
using _5GunOdev.Contre;

namespace _5GunOdev
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                CustomerName = "Enes",
                CustomerSurname = "Celep",
                CustomerDateOfBirth = new DateTime(2236,2,25),
                CustomerIdentityKey = 12345678912
            };
            Game game1 = new Game
            {
                GameId = 1,
                GameName = "GTA 5",
                GamePrice = 169.90
            };
            Campaign campaign1 = new Campaign
            {
                Id = 1,
                DiscountRate = 15,
            };

            Discount makeDiscount = new Discount();
            

            /*Check check = new Check();
            var a=check.CheckIfRealPerson(customer1);
            Console.WriteLine(a);*/
        }
    }
}
