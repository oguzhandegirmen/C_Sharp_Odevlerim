using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev22_
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            Console.Write("\nGiridiğiniz Sayının Tam Bölenleri: ");
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.Write(i + "-");
                }
            }
            Console.ReadLine();
        }
    }
}
