using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev10
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 4;
            for (i = 4; i <= 1000; i++)
            {

                if ((i * i) <= 1000)
                {
                    Console.WriteLine(Math.Pow(i, 2));
                }
            }
            Console.ReadLine();
        }
    }
}
