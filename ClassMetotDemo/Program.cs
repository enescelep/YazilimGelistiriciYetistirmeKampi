using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Name = "Enes";
            musteri1.Surname = "Celep";
            musteri1.Id = 05;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Ahmet";
            musteri2.Surname = "Güngör";
            musteri2.Id = 06;

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            int hak = 3;
            tekrar:
            Console.WriteLine("İşlem seçiniz:\n1-Müşteri Ekleme\n2-Müşteri Silme\n3-Müşteri Listeme\nSeçiminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());


            if (hak <= 3 && hak >= 0)
            {
                if (secim == 1)
                {
                    musteriManager.MusteriEkle();
                }
                else if (secim == 2)
                {
                    Console.WriteLine("Müşteri seçiniz:\n1-" + musteri1.Name + "\n2-" + musteri2.Name + "\nSeçiminiz: ");
                    int musteriSecim = Convert.ToInt32(Console.ReadLine());
                    if (musteriSecim == 1)
                    {
                        musteriManager.MusteriSil(musteri1);
                    }
                    else if (musteriSecim == 2)
                    {
                        musteriManager.MusteriSil(musteri2);
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir seçim yapmalısınız.");
                    }
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Müşteri seçiniz:\n1-" + musteri1.Name + "\n2-" + musteri2.Name + "\nSeçiminiz: ");
                    int musteriSecim = Convert.ToInt32(Console.ReadLine());
                    if (musteriSecim == 1)
                    {
                        musteriManager.MusteriListele(musteri1);
                    }
                    else if (musteriSecim == 2)
                    {
                        musteriManager.MusteriListele(musteri2);
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir seçim yapmalısınız.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçerli bir seçim yapmalısınız.");
                    hak--;
                    Console.WriteLine("Kalan hakkınız: " + hak);
                    goto tekrar;
                }
            }
            else
            {
                Console.WriteLine("Seçim hakkınız bitti.\nProgram kapatılıyor.");
            }
        }
    }

}
