using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Helal! Sepete eklendi: " + urun.Adi);

        }

        public void Ekle2(string urunadi, string aciklama, double fiyat, int stokAdedi)
        {
            if (stokAdedi < 10)
            {
                Console.WriteLine();
            }
            Console.WriteLine("Helal! Sepete eklendi: " + urunadi);
        }
    }
}
