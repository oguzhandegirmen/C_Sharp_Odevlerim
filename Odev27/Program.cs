using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev27
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, i;

            Console.Write("Bir Sayı Giriniz : ");

            sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi > 0)

            {

                Console.WriteLine("{0}", sayi);

                sayi -= 5;

            }

            Console.ReadKey();
        }
    }
}
