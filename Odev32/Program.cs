using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev32
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string a;
            Double toplama, cikartma, carpma, bolme;
            Console.Write("Lütfen 1. Sayıyı Giriniz = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen 2. Sayıyı Giriniz = ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Toplama İşlemi İçin-----> +");
            Console.WriteLine("Çıkarma işlemi İçin-----> -");
            Console.WriteLine("Bölme İşlemi İçin  -----> /");
            Console.WriteLine("Çarpma İşlemi İçi  -----> *");
            Console.Write("Lütfen Gerçekleştirmek İstediğiniz İşlemi Giriniz = ");
            a = Convert.ToString(Console.ReadLine());
            toplama = x + y;
            cikartma = x - y;
            carpma = x * y;
            bolme = x / y;
            if (a == "+")
            {
                Console.WriteLine("\nİşleminizin Sonucu : " + toplama);
            }
            else if (a == "-")
            {
                Console.WriteLine("\nİşleminizin Sonucu : " + cikartma);
            }

            else if (a == "*")
            {
                Console.WriteLine("\nİşleminizin Sonucu : " + carpma);
            }
            else if (a == "/")
            {
                Console.WriteLine("\nİşleminizin Sonucu : " + bolme);
            }
            else
                Console.WriteLine("\nHatalı Operatör Seçimi Yaptınız!");
            Console.ReadLine();
        }
    }
}
