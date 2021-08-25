using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            double taban = 0;
            double us = 0;
            double sonuc = 1;

            Console.WriteLine("Taban Sayısını Giriniz: ");
            taban = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Üs Sayısını Giriniz: ");
            us = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= us; i++)
            {
                sonuc = sonuc * taban;
            }
            Console.WriteLine(taban + " Üssü " + us + " = " + sonuc);
            Console.ReadKey();
        }
    }
}
