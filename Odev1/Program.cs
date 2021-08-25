using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sayi3, sayi4;
            Console.WriteLine("Birinci sayıyı giriniz: ");

            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");

            sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Üçüncü sayıyı giriniz: ");

            sayi3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Dördüncü sayıyı giriniz: ");

            sayi4 = Convert.ToInt16(Console.ReadLine());
            if (sayi1 > sayi2 && sayi1 > sayi3 && sayi1 > sayi4)
            {
                Console.Write("En büyük sayı: " + sayi1);
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3 && sayi2 > sayi4)
            {
                Console.Write("En büyük sayı: " + sayi2);
            }
            else if (sayi3 > sayi1 && sayi3 > sayi2 && sayi3 > sayi4)
            {
                Console.Write("En büyük sayı: " + sayi3);
            }
            else
            {
                Console.Write("En büyük sayı: " + sayi4);
            }
            Console.ReadKey();
        }
    }
}
