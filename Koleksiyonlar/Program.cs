using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "enes", "engin", "kerim", "kerem" };

            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string>() { "enes", "engin", "kerim", "kerem" };
            isimler2.Add("mahmut");

            foreach (string ad in isimler2)
            {
                Console.WriteLine(ad);
            }
            //Console.WriteLine(isimler2[4]);
        }
    }
}