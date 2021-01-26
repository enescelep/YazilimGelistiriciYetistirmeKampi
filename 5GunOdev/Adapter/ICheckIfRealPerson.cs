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
        public bool CheckIfRealPerson(Customer customer)
        {
            return CheckRealPerson(customer).Result;
        }
        public static async Task<bool> CheckRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var durum = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.CustomerIdentityKey), (customer.CustomerName),
                (customer.CustomerSurname), (customer.CustomerDateOfBirth.Year)));
            return durum.Body.TCKimlikNoDogrulaResult;
        }
    }
}

