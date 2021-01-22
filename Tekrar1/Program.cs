using System;

namespace Tekrar1
{
    class Program
    {
        static void Main(string[] args)
        {
            void kontrol(int a)
            {
                int carpanSayisi = 0;
                if (a == 1)
                {
                    Console.WriteLine("Sayı asal değildir.");
                    Environment.Exit(0);
                }
                else if (a == 2)
                {
                    Console.WriteLine("Sayı asaldır.");
                    Environment.Exit(0);
                }
                else if (a < 1)
                {
                    Console.WriteLine("Girilen sayı pozitif olmalıdır.");
                    Environment.Exit(0);
                }
                for (int carpan = 2; carpan < a; carpan++)
                {
                    if (a % carpan == 0)
                    {
                        carpanSayisi++;
                    }
                }
                if (carpanSayisi > 0)
                {
                    Console.WriteLine("Sayı asal değildir.");
                }
                else
                {
                    Console.WriteLine("Sayı asaldır.");
                }
            }
            /*int yas;
            Console.WriteLine("Yaşınızı giriniz: ");
            yas = Convert.ToInt16(Console.ReadLine());

            string sonuc = yas < 18 ? "Kayıt olamazsınız" : "Kayıt olabilirsiniz.";
            Console.WriteLine(sonuc);

            nefl ders1 = new nefl();
            ders1.Hoca = "Ramazan";
            ders1.DersAdi = "Matematik";
            ders1.DersNotu = "90";

            nefl ders2 = new nefl();
            ders2.Hoca = "Talip";
            ders2.DersAdi = "Kimya";
            ders2.DersNotu = "90";

            nefl[] dersler = new nefl[] {ders1,ders2};

            foreach (var hocalar in dersler)
            {
                Console.WriteLine(hocalar.Hoca);
            }*/

            Console.Write("Sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            kontrol(sayi);
        }
    }
    class nefl
    {
        public string Hoca { get; set; }
        public string DersAdi { get; set; }
        public string DersNotu { get; set; }
    }
}
