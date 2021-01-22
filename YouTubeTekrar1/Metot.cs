using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YouTubeTekrar1
{
    class Metot
    {
        public int Ekle(ref int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
            sayi1 = 0;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Carp(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            return sayi1 * sayi2 * sayi3 * sayi4;
        }
        public int Topla(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
