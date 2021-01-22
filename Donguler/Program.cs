using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java geliştiricisi olma kampı";

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı",
            "Programlamaya başlangıç için temel kurs",
            "Java geliştiricisi olma kampı",
            "Python geliştirici olma kampı"};
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n---------------------\n");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("\n---------------------\n");
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}