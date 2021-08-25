using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıyı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int x = 1; x <= sayi; x++)
            {
                int carpim = 1;
                for (int i = 1; i <= x; i++)
                {
                    carpim *= i;
                }
                toplam += carpim;
            }
            Console.WriteLine("Sonuç : " + toplam);
            Console.ReadKey();


        }
    }
}
