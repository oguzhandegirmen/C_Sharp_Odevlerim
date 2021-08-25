using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            float maas1, maas2;
            Console.WriteLine("Şimdiki Maaşınızı Giriniz : ");
            maas1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                maas2 = (maas1 * 15) / 100;
                maas1 = maas1 + maas2;
            }
            Console.WriteLine("5 Yıl Sonraki Zamlı Maaş : " + maas1 + " TL");
            Console.ReadKey();
        }
    }
}
