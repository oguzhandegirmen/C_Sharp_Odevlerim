using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ornek35
{
    class Program
    {
        static void Main(string[] args)
        {
            int santigrat = 0;
            do
            {
                double fahrenayt = santigrat * 1.8 + 32;
                Console.WriteLine("{0}°C eşittir {1}°F", santigrat, fahrenayt);
                santigrat += 5;
            } while (santigrat <= 100);
            Console.ReadLine();
        }
    }
}
