using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, tek = 0, cift = 0, sifir = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + ".sayıyı giriniz:");
                sayi = Convert.ToInt16(Console.ReadLine());
                if (sayi == 0)
                {
                    sifir++;
                }
                else if (sayi % 2 == 0)
                {
                    cift++;
                }
                else
                {
                    tek++;
                }
            }
            Console.WriteLine("\nTek Sayı  >>> " + tek);
            Console.WriteLine("Çift Sayı >>> " + cift);
            Console.WriteLine("Sıfır     >>> " + sifir);
            Console.ReadKey();
        }
    }
}
