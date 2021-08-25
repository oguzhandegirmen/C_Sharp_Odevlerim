using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev15
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi, kucuk, buyuk, toplam = 0, ortalama, kucukBuyukOrtalama;
            Console.Write("Sayıyı gir : ");
            sayi = Convert.ToDouble(Console.ReadLine());
            kucuk = sayi;
            buyuk = sayi;
            toplam += sayi;
            for (int i = 1; i < 10; i++)
            {
                Console.Write("Sayıyı gir : ");
                sayi = Convert.ToDouble(Console.ReadLine());
                toplam += sayi;
                if (sayi > buyuk)
                {
                    buyuk = sayi;
                }
                if (sayi < kucuk)
                {
                    kucuk = sayi;
                }
            }
            ortalama = toplam / 10;
            kucukBuyukOrtalama = (kucuk + buyuk) / 2;
            Console.WriteLine("Girilen En Küçük Sayı : {0}", kucuk);
            Console.WriteLine("Girilen En Büyük Sayı : {0}", buyuk);
            Console.WriteLine("Sayıların Ortalaması : {0}", ortalama);
            Console.WriteLine("En küçük ve En büyük Sayı Ortalaması : {0}", kucukBuyukOrtalama);
            Console.WriteLine("Ortalamaların Farkı : {0}", ortalama - kucukBuyukOrtalama);
            Console.ReadKey();
        }
    }
}
