using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev.Entities;

namespace _5GunOdev.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
