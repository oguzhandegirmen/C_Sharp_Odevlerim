using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sayıyı girin :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı girin :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int  obeb = 1;

            

            for (int i = 1; i <= sayi1 && i <= sayi2; i++)
                if (sayi2 % i == 0 && sayi1 % i == 0)
                    obeb = i;

            Console.WriteLine("" + obeb);

            Console.ReadLine();
        }
    }
}
