using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev7
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi, i, sonuc;
            Console.WriteLine("Bir Sayı Giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                sonuc = sayi * i;
                Console.WriteLine("{0} x {1} = {2}", sayi, i, sonuc);
            }
            Console.ReadLine();
        }
    }
}
