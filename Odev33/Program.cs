using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev33
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, toplam = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Bir sayı giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 3 == 0)
                    toplam = toplam + 1;
               

            } 
            Console.WriteLine("3 ile tam bölünenlerin sayısı : " + toplam);
                Console.ReadLine();
        }
    }
}
