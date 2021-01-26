using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev.Abstract;
using _5GunOdev.Entities;

namespace _5GunOdev.Contre
{
    class Discount : IMakeDiscount
    {
        int IMakeDiscount.MakeDiscount(Game game, Campaign campaign, Customer customer)
        {
            game.GamePrice = game.GamePrice - game.GamePrice * campaign.DiscountRate;
            return (int)game.GamePrice;
            //Console.WriteLine(customer.CustomerName+" bought" + game.GameName +".\nGame price:"+game.GamePrice);
        }
    }
}
