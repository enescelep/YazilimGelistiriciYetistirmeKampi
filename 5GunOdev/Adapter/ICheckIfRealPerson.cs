using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using _5GunOdev.Entities;
using ServiceReference1;

namespace _5GunOdev.Adapter
{
    class Check : IMernisServiceAdapter
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return CheckRealPerson(gamer).Result;
        }
        public static async Task<bool> CheckRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var durum = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityID), (gamer.Name),
                (gamer.LastName), (gamer.DateOfBirth.Year)));
            return durum.Body.TCKimlikNoDogrulaResult;
        }
    }
}

