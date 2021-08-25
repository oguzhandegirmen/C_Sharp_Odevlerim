using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, kalan = 0, para;
            Console.Write("Çekmek istediğiniz miktarı giriniz: ");
            sayi = int.Parse(Console.ReadLine());
            para = sayi / 200;
            kalan = sayi;
            kalan = kalan - (para * 200);
            Console.WriteLine("200 lük : " + para);
            para = kalan / 100;
            Console.WriteLine("100 lük : " + para);
            kalan = kalan - (para * 100);
            para = kalan / 50;
            Console.WriteLine("50 lik : " + para);
            kalan = kalan - (para * 50);
            para = kalan / 10;
            Console.WriteLine("10 lik : " + para);
            kalan = kalan - (para * 10);
            para = kalan / 5;
            Console.WriteLine("5 lik : " + para);
            Console.ReadKey();
        }
    }
}
