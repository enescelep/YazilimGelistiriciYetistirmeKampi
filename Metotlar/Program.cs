using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string tl = " TL";

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya elması";
            urun1.Fiyati = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.Fiyati = 80;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati + tl);
                Console.WriteLine();
            }

            Console.WriteLine("------------Metotlar------------");

            SepetManager sepetManager = new SepetManager();
            //sepetManager.Ekle(urun1);
            //sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "Taze Armut", 5, 5);
            sepetManager.Ekle2("Elma", "Taze Elma", 10, 2);
            sepetManager.Ekle2("Karpuz", "Taze Karpuz", 15, 10);
        }
    }
}