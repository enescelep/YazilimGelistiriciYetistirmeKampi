using System;
using System.Collections.Generic;
using System.IO;

namespace _4GunOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            /*List<int> plakalar = new List<int>();
            List<string> iller = new List<string>() {"adana","istanbul","ankara" };
            for (int i = 1; i <= iller.Count; i++)
            {
                plakalar.Add(i);
            }
            for (int i = 0; i < iller.Count; i++)
            {
                myDictionary.Add(plakalar[i], iller[i]);
            }
            Console.WriteLine(myDictionary.GetValue(2));*/

            string[] arguments;
            try
            {
                FileStream liste = new FileStream(@"C:\Users\user\Desktop\iller.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(liste);
                string line;
                List<int> plakalar = new List<int>();
                List<string> iller = new List<string>();
                while ((line = reader.ReadLine())!=null)
                {
                    arguments = line.Split(':');
                    plakalar.Add(Convert.ToInt32(arguments[0]));
                    iller.Add(arguments[1]);
                }
                for (int i = 0; i < plakalar.Count; i++)
                {
                    myDictionary.Add(plakalar[i], iller[i]);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int hak = 5;
            while (hak!=0)
            {
                try
                {
                    Console.WriteLine("Plaka giriniz: ");
                    int plaka = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(myDictionary.GetValue(plaka));

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    // break;
                }
                finally { hak--; }
            }
        }
    }
}