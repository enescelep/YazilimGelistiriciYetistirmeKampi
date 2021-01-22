using System;

namespace Tekrar2
{
    class Program
    {
        static void Main(string[] args)
        {

            UrunBilgisi urun1 = new UrunBilgisi();
            urun1.Ad = "Mouse";
            urun1.Aciklama = "Sıfır mouse";
            urun1.Fiyat = 60;

            HosgeldinMesaji Hg = new HosgeldinMesaji();
            Hg.EkranaYazdir(urun1);
        }
    }
}