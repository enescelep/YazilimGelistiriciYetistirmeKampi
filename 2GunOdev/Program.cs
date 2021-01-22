using System;

namespace _2.GunOdev
{
    class Program
    {
        static void Main(string[] args)
        {

            UrunBilgisi urun1 = new UrunBilgisi();
            urun1.urunAdi = "Asus Laptop";
            urun1.urunFiyati = 9999.90;
            urun1.urunTuru = "Bilgisayarlar";

            UrunBilgisi urun2 = new UrunBilgisi();
            urun2.urunAdi = "MSI Monitör";
            urun2.urunFiyati = 1699.90;
            urun2.urunTuru = "Monitörler";

            UrunBilgisi urun3 = new UrunBilgisi();
            urun3.urunAdi = "Steelseries Kulaklık";
            urun3.urunFiyati = 999.90;
            urun3.urunTuru = "Kulaklıklar";


            UrunBilgisi[] urunler = new UrunBilgisi[] { urun1, urun2, urun3 };

            Console.WriteLine("Ürün Adı : Ürün Fiyatı : ÜrünTürü");


            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi + " : " + urunler[i].urunFiyati + " : " + urunler[i].urunTuru);
            }

            Console.WriteLine();

            foreach (var urunListele in urunler)
            {
                Console.WriteLine(urunListele.urunAdi + " : " + urunListele.urunFiyati + " : " + urunListele.urunTuru);
            }

            Console.WriteLine();

            int j = 0;
            while (j != urunler.Length)
            {
                if (j != urunler.Length)
                {
                    Console.WriteLine(urunler[j].urunAdi + " : " + urunler[j].urunFiyati + " : " + urunler[j].urunTuru);
                    j++;
                }
                else
                {
                    break;
                }
            }
        }
    }

    class UrunBilgisi
    {
        public string urunAdi { get; set; }
        public double urunFiyati { get; set; }
        public string urunTuru { get; set; }
    }
}
