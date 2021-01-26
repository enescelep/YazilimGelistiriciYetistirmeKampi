using System;
using System.Collections.Generic;
using System.Text;

namespace _5GunOdev.Entities
{
    class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public long CustomerIdentityKey { get; set; }
        public DateTime CustomerDateOfBirth { get; set; }
    }
}
