using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev28
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            double sayi = 0, toplam = 0, ortalama = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.Write("{0}.sayı giriniz : ", i);
                sayi = double.Parse(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    toplam += sayi;
                    sayac++;
                }
            }
            ortalama = toplam / sayac;
            Console.WriteLine("\nGirilen 20 Sayıdan Çift Olanların Ortalaması ={0}", ortalama);
            Console.ReadLine();
        }
    }
}
