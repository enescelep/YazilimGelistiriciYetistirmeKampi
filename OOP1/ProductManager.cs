using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOP1
{
    class ProductManager
    {
        //Product product = new Product();
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
    }
}