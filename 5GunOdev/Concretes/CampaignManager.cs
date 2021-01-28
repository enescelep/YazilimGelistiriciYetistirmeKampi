using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev.Abstract;
using _5GunOdev.Entities;

namespace _5GunOdev.Concretes
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} added!",campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} deleted!", campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} updated!", campaign.Name);
        }
    }
}
