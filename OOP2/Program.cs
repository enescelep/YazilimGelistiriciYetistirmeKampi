using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri
            {
                Id = 1,
                MusteriNo = "12345",
                Adi = "Enes",
                Soyadi = "Celep",
                TcNo = "1234567890"
            };

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri
            {
                Id = 2,
                MusteriNo = "54321",
                SirketAdi = "Kodlama.io",
                VergiNo = "1234567890"
            };
            //Gerçek Müşteri - Tüzel Müşteri

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}
