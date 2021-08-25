using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(" {0}. Hakkınız, sayıyı giriniz : ", i);
                int girilenSayi = int.Parse(Console.ReadLine());

                if (girilenSayi == sayi)
                {
                    Console.WriteLine("Tebrikler sayıyı tahmin ettiniz.");
                    break;
                }

                else if (girilenSayi < sayi)
                {
                    Console.WriteLine("Yukarı ");
                    continue;
                }

                else if (girilenSayi > sayi)
                {
                    Console.WriteLine("Aşağı ");
                    continue;
                }
            }

            Console.ReadKey();
        }
    }
}
