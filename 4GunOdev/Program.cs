using System;
using System.Collections.Generic;

namespace _4GunOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            List<int> plakalar = new List<int> {};
            List<string> iller = new List<string> {"Adana","Adıyaman","Afyon","Ağrı","Amasya","Ankara","Antalya","Artvin","Aydın","Balıkesir"};
            /*myDictionary.Add(1, "adana");
            myDictionary.Add(5, "amasya");
            myDictionary.Add(34, "istanbul");
            myDictionary.Add(6, "antalya");
            Console.WriteLine(myDictionary.Length);
            Console.WriteLine(myDictionary.GetKey("istanbul"));
            Console.WriteLine(myDictionary.GetValue(34));*/

            for (int i = 1; i <= plakalar.Count; i++)
            {
                plakalar.Add(i);
            }
            for (int i = 0; i < plakalar.Count; i++)
            {
                myDictionary.Add(plakalar[i], iller[i]);
            }
            Console.WriteLine(myDictionary.Length);
            Console.WriteLine("-------------------");

            for (int i = 0; i < myDictionary.Length; i++)
            {
                int plakaSayisi = plakalar[i];
                Console.WriteLine(plakaSayisi + " | " + myDictionary.GetValue(plakaSayisi));
            }
        }
    }
}