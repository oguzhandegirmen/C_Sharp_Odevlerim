using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev16
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, bin, binkalan, yuz, yuzkalan, on, onkalan, bir, fark;
            Console.WriteLine("Bir sayı giriniz :  ");
            sayi = Convert.ToInt32(Console.ReadLine());
            string cevir = sayi.ToString();
            if (cevir.Length == 4)
            {
                bin = sayi / 1000;
                binkalan = sayi - (bin * 1000);
                yuz = binkalan / 100;
                yuzkalan = binkalan - (yuz * 100);
                on = yuzkalan / 10;
                onkalan = yuzkalan - (on * 10);
                bir = onkalan * 1;
                Console.Write("binler basamağı: {0}\n yüzler basamağı: {1},\n onlar basamağı: {2},\n birler basamağı: {3} ", bin, yuz, on, bir);
                fark = (yuz - (yuz / 3) * 3) - bir;
                Console.WriteLine("fark" + fark);
            }

            Console.ReadKey();
        }
    }
}
