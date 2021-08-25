using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev31
{
    class Program
    {
        static void Main(string[] args)
        {
            int carpim = 0, x, y;
            Console.Write("Sayi giriniz:"); 
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayi giriniz:");
            y = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < y; i++) { carpim = carpim + x; }
            Console.Write(x + "*" + y + "=" + carpim); Console.ReadKey();
            Console.ReadLine();
        }
    }
}
