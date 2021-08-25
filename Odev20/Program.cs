using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev20
{
    class Program
    {
        static void Main(string[] args)
        {
            double girilen, mak = 0, min = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + ".Sayıyı Giriniz : ");
                girilen = Convert.ToDouble(Console.ReadLine());
                if (girilen > mak)
                    mak = girilen;
                if (i == 1)
                    min = girilen;
                if (girilen < min)
                    min = girilen;
            }
            Console.WriteLine("\nGirilen Sayılardan En Büyüğü : " + mak);
            Console.WriteLine("Girilen Saylardan En Küçüğü : " + min);
            Console.ReadLine();
        }
    }
}
