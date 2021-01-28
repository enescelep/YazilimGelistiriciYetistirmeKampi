using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using _5GunOdev.Entities;


namespace _5GunOdev.Adapter
{
    interface IMernisServiceAdapter
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
