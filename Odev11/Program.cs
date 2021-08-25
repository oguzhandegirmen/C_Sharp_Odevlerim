using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            string cikti = "";
            for (int i = 1; i < sayi + 1; i++)
                for (int x = 0; x < i; x++)
                    cikti = cikti + i;

            Console.WriteLine(cikti);
            Console.ReadKey();

        }
    }
}
