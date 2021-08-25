using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEn Fazla 4 Basamaklı Bir Sayı Giriniz : ");
            int sayı = Convert.ToInt16(Console.ReadLine());
            int birler = sayı % 10;
            sayı = sayı / 10;
            int onlar = sayı % 10;
            sayı = sayı / 10;
            int yüzler = sayı % 10;
            sayı = sayı / 10;
            int binler = sayı % 10;
            sayı = sayı / 10;
            Console.WriteLine("\nBirler Basamağı: {0} ", birler);
            Console.WriteLine("Onlar Basamağı : {0} ", onlar);
            Console.WriteLine("Yüzler Basamağı: {0} ", yüzler);
            Console.WriteLine("Binler Basamağı: {0} ", binler);
            int toplam = birler + onlar + yüzler + binler;
            Console.WriteLine("\nBasamak Değerleri Toplamı {0} ", toplam);
            Console.ReadKey();
        }
    }
}
