using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,sayi;
            int faktoriyel = 1;

            Console.Write("Sayıyı Giriniz : ");
            sayi = int.Parse(Console.ReadLine());

            for (i = sayi; i > 1; i--)
            {

                faktoriyel = faktoriyel * i;

            }            

            Console.Write("Faktöriyel = " + faktoriyel);
            Console.ReadLine();
        }
    }
}
