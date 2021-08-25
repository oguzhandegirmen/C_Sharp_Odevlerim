using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev26
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1. Sayiyi giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayiyi giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int max = sayi1 * sayi2;
            int ekok = 0;

            for (int i = max; i > 0; i--)
            {
                if (i % sayi1 == 0 && i % sayi2 == 0)
                {
                    ekok = i;
                }
            }
            Console.WriteLine("Ekok : " + ekok);

            Console.ReadLine();
        }
    }
}
