using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev23
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, sayi3;
            Console.WriteLine("ilk sayıyı giriniz: ");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("üçüncü sayıyı giriniz: ");
            sayi3 = Convert.ToInt16(Console.ReadLine());
            if (sayi1 > sayi2 && sayi1 > sayi3 )
            {
                if (sayi2 > sayi3)
               {               
                  Console.Write("Ortanca sayı :" + sayi2);
               }
                 else
               {
                  Console.Write("Ortanca sayı :" + sayi3);
               }
           }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                if (sayi1>sayi3)
                {
                   Console.Write("Ortanca sayı :" + sayi1);
                }
                else
                {
                    Console.Write("Ortanca sayı :" + sayi3);
                }
            }
            else
            {
                if (sayi2 > sayi1)
                {
                    Console.Write("Ortanca sayı :" + sayi2);
                }
                else
                {
                    Console.Write("Ortanca sayı :" + sayi1);
                }
            }
            Console.ReadLine();
        }
    }
}
