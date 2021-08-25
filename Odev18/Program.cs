using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev18
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi, birler, onlar, yuzler, binler;
            Console.Write("\nBir sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());

            birler = sayi % 10;
            sayi = sayi / 10;
            onlar = sayi % 10;
            sayi = sayi / 10;
            yuzler = sayi % 10;
            sayi = sayi / 10;
            binler = sayi % 10;
            Console.WriteLine("Binler Basamağı:" + binler);
            Console.WriteLine("Yüzler Basamağı:" + yuzler);
            Console.WriteLine("Onlar Basamağı :" + onlar);
            Console.WriteLine("Birler Basamağı:" + birler);
            Console.ReadKey();

        }
    }
}
