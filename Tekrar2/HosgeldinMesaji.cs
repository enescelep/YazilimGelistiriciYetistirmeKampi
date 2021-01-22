using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar2
{
    class HosgeldinMesaji
    {
        public void EkranaYazdir(UrunBilgisi urun)
        {
            Console.WriteLine(urun.Ad + " | " + urun.Aciklama + " | " + urun.Fiyat);
        }
    }
}
