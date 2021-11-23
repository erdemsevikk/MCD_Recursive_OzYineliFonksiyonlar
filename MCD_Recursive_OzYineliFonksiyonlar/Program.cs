using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Recursive_OzYineliFonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                long sayiFaktoriyel = Faktoriyel(i);
                Console.WriteLine($"{i} sayısının faktoriyeli = " + sayiFaktoriyel);
            }


            Console.ReadLine();
        }

        static long Faktoriyel(long sayac)
        {
            //Metot kendi icinde kendisini cagiriyor
            //böyle metotlara recursive oz yineli fonksiyon denir

            if (sayac <= 1)
            {
                return 1;
            }

            return sayac * Faktoriyel(sayac - 1);
        }
    }
}
