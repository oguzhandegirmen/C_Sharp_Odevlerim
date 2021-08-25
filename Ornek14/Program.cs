using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ornek14
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 100; i++)
            {
                bool asalmi = true;
                for (int a = 2; a < i; a++)
                {
                    if (i % a == 0)
                    {
                        asalmi = false;
                        break;
                    }
                }
                if (asalmi)
                    Console.Write(" " + i);
            }
            Console.ReadLine();
        }
    }
}
