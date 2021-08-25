using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kenar uzunluğunu giriniz : ");
            int Kenar = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Kenar; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Kenar; j++)
                {
                    Console.Write(" *");
                }
                Console.ReadKey();
            }
        }
    }
}
