using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev.Entities;

namespace _5GunOdev.Abstract
{
    interface IMakeDiscount
    {
        public int MakeDiscount(Game game, Campaign campaign, Customer customer);
    }
}
