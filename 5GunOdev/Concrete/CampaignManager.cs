using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev.Abstract;
using _5GunOdev.Entities;

namespace _5GunOdev.Concrete
{
    class CampaignManager : IManagerService<Campaign>
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine("Added");
            Get(entity);
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine("Deleted");
            Get(entity);
        }

        public void Get(Campaign entity)
        {
            Console.WriteLine("CampaignID: {0}  | DiscountRate: {1}", item.Id, item.DiscountRate);
        }

        public void GetAll(List<Campaign> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("CampaignID: {0}  | DiscountRate: {1}", item.Id, item.DiscountRate);
            }
            Console.WriteLine();
        }

        public void Update(Campaign entity)
        {
            throw new NotImplementedException();
        }
    }
}
