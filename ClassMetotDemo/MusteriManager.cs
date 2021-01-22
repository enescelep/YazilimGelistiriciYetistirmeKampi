using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle()
        {
            Musteri musteri = new Musteri();
            Console.Write("Müşterinin adını giriniz:"); musteri.Name = Convert.ToString(Console.ReadLine());
            Console.Write("Müşterinin soyadını giriniz:"); musteri.Surname = Convert.ToString(Console.ReadLine());
            Console.Write("Müşterinin ID'sini giriniz:"); musteri.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Müşteri eklendi.");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " müşterisi silindi.");
        }
        public void MusteriListele(Musteri musteri)
        {
            Musteri[] musteriler = new Musteri[] { musteri };
            foreach (var client in musteriler)
            {
                Console.WriteLine("Ad | Soyad | Id");
                Console.WriteLine(client.Name + " " + client.Surname + " " + client.Id);
            }
        }
    }
}
