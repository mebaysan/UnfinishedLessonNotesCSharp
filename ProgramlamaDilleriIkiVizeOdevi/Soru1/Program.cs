using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam_pozitif = 0;
            int toplam_negatif = 0;
            while (true)
            {
                Console.WriteLine("Bir sayı girin: ");
                float sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == -1)
                {
                    break;

                }
                else if (sayi >= 0)
                {
                    toplam_pozitif = toplam_pozitif + 1;
                }
                else if (sayi < 0)
                {
                    toplam_negatif = toplam_negatif + 1;
                }
            }
            Console.WriteLine(String.Format("Toplam {0} Pozitif\nToplam {1} Negatif", toplam_pozitif, toplam_negatif));
            Console.ReadLine();
        }
    }
}
