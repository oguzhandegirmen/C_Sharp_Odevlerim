using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev24
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sonuc, sayac;
            Console.Write("1. sayıyı girin :");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı girin :");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            sonuc = sayi1;

            for (sayac = 0; sayi2 <= sonuc; sayac++)
            {
                sonuc = sonuc - sayi2;
            }
            Console.WriteLine("Bölüm>>" + sayac);
            Console.WriteLine("kalan>>" + sonuc);
            Console.ReadKey();
        }
    }
}
