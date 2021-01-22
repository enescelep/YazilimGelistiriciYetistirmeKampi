using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas = 14;
            string ad = "Enes";

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Kerem Varış";
            kurs2.KursAdi = "Java";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.KursAdi = "Python";
            kurs3.IzlenmeOrani = 80;


            //Console.WriteLine(kurs1.KursAdi+ "\n" + kurs1.Egitmen+ "\n"+ kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen);
            }

            Console.WriteLine();
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
