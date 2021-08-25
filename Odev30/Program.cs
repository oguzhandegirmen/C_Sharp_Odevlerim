using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev30
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sonuc;
            Console.Write("\nHangi sayıya kadar kareler toplansın? : ");
            sayi = Convert.ToInt16(Console.ReadLine());
            sonuc = (sayi * (sayi + 1) * (2 * sayi + 1)) / 6;
            Console.WriteLine("\n{0}'e kadar olan sayıların karelerinin toplamı : {1}", sayi, sonuc);
            Console.ReadLine();
        }
    }
}
