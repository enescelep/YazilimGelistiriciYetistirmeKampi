using System;

namespace YouTubeTekrar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Metot metot = new Metot();
            int n1 = 20;
            int n2 = 60;
            var sonuc = metot.Ekle(ref n1, n2);
            //Console.WriteLine(sonuc);
            //Console.WriteLine(n1);

            //sonuc = metot.Carp(10,5); Console.WriteLine(sonuc);
            //sonuc = metot.Carp(10, 5, 3,2); Console.WriteLine(sonuc);

            int[] sayilar = new int[] { 10, 20, 30, 40, 50, 60, };
            Console.WriteLine(metot.Topla(sayilar));

        }
        /*ref ile out mantık olarak aynı şeylerdir.
          ref ile önceden değer oluşturulması lazım. out'da böyle bir şey yok.
          out'da değiştirmek zorunlu*/
    }
}
