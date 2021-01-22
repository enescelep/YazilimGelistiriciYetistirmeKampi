using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("ahmet");
            isimler.Add("enes");
            isimler.Add("engin");
            // Console.WriteLine();
        }
    }
}
