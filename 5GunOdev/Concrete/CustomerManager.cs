using System;
using System.Collections.Generic;
using System.Text;
using _5GunOdev.Entities;
using _5GunOdev.Abstract;

namespace _5GunOdev.Concrete
{
    class CustomerManager : IManagerService<Customer>
    {
        public void Add(Customer entity)
        {
            Console.WriteLine("Added!");
            Get(entity);
        }

        public void Delete(Customer entity)
        {
            Console.WriteLine("Deleted!");
            Get(entity);
        }
        public void Update(Customer entity)
        {
            Console.WriteLine("Updated!");
            Get(entity);
        }
        public void Get(Customer entity)
        {
            Console.WriteLine("CustomerName: {0}  |  CustomerLastName: {1} | CustomerIdentityKey {2} | CustomerDateOfBirth {3}\n", entity.CustomerName, entity.CustomerSurname, entity.CustomerIdentityKey, entity.CustomerDateOfBirth);
        }

        public void GetAll(List<Customer> entities)
        {
            foreach (var item in entities)
            {
                Console.WriteLine("CustomerName: {0}  |  CustomerLastName: {1} | CustomerIdentityKey {2} | CustomerDateOfBirth {3}\n", entity.CustomerName, entity.CustomerSurname, entity.CustomerIdentityKey, entity.CustomerDateOfBirth);
            }
            Console.WriteLine();
        }
    }
}
