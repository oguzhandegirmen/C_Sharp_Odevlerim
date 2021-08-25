using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 - inch > cm\n" +
                          "2 - kg > lbs\n" +
                          "3 - °C > °F\n" +
                          "Çevirmek istediğiniz birimin sayısını girin: ");
            string islem = Console.ReadLine(), deger;
            if (islem != "")
            {
                double sayi;
                Console.WriteLine("Sayı girin: ");
                deger = Console.ReadLine();
                if (deger != "")
                {
                    sayi = Convert.ToDouble(deger);
                    if (islem == "1")
                        deger = "\n" + sayi + " inch  >  " + (sayi * 2.54) + " cm dir.";
                    else if (islem == "2")
                        deger = "\n" + sayi + " kg  >  " + (sayi * 2.204) + " libre's dir.";
                    else if (islem == "3")
                        deger = "\n" + sayi + "°C  >  " + ((9.0 / 5.0) * sayi + 32).ToString("F04") + "°F dır.";
                    else
                        deger = "Böyle bir birim çevirisi bulunmamaktadır!";
                }
                else
                    deger = "\nSayıyı boş girmemelisiniz!";
            }
            else
                deger = "\nBoş seçim yapmamalısınız!";

            Console.WriteLine(deger);
            Console.ReadKey();
        }
    }
}
