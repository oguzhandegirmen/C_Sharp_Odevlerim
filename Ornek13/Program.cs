using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ornek13
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam = 0;
            Console.Write("1. Sayı : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            for (int i = sayi1; i <= sayi2; i++)
            {
                toplam += i;
            }
            Console.WriteLine("{0} ile {1} arasındaki sayıların toplamı : {2}", sayi1, sayi2, toplam);
            Console.ReadKey();
        }
    }
}
