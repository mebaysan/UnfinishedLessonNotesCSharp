using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabanDegerveUs
{
    class Program
    {
        static void Main(string[] args)
        {
            int taban, us,sonuc=1;
            Console.WriteLine("Taban değerini girin : ");
            taban = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üs değerini girin : ");
            us = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= us; i++)
            {
                sonuc = sonuc * taban;
            }

            Console.WriteLine("Sonuç = " + sonuc);
            

            Console.Read();
        }
    }
}
