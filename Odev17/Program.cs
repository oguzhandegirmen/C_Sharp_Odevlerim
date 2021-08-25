using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev17
{
    class Program
    {
        static void Main(string[] args)
        {
            int sinav1, sinav2, sinav3;
            Console.Write("\n1. sınav notunu giriniz: ");
            sinav1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n2. sınav notunu giriniz: ");
            sinav2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n3. sınav notunu giriniz: ");
            sinav3 = Convert.ToInt32(Console.ReadLine());
            if ((sinav1 * 20 / 100 + sinav2 * 30 / 100 + sinav3 * 50 / 100) >= 50)
                Console.WriteLine("\nGEÇTİ");
            else
            Console.WriteLine("\nKALDI");
            Console.ReadLine();
        }

    }
}
