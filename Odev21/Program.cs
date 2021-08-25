using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev21
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, pozitif = 0, negatif = 0;
            for(int a=1; a<=20; a++)
            {
                Console.WriteLine(a + ". sayıyı giriniz : ");
                sayi = Convert.ToInt16(Console.ReadLine());
                if (sayi>0)
                {
                    pozitif++;
                }
                else if (sayi <0)
                {
                    negatif--;
                }
               
              } 
           Console.WriteLine("Pozitif sayılar {0} tanedir ", pozitif);
                Console.WriteLine("Negatif sayılar {0} tanedir ", negatif);
                Console.ReadLine();
        }
    }
}
