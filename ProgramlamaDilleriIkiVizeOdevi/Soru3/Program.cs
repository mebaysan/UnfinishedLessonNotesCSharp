using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç saat internet kullandınız:    ");
            int kac_saat = Convert.ToInt32(Console.ReadLine());
            int ucret = 0;
            if (0 < kac_saat && kac_saat <= 29)
            {
                ucret = 29;
            }
            else if (30 <= kac_saat && kac_saat <= 89)
            {
                ucret = 25 + ((kac_saat - 30) * 1);
            }
            else if (90 <= kac_saat && kac_saat <= 149)
            {
                ucret = 66 + ((kac_saat - 90) * 2);
            }
            else if (150 <= kac_saat && kac_saat <= 299)
            {
                ucret = 75 + ((kac_saat - 150) * 3);
            }
            else if (300 <= kac_saat)
            {
                ucret = 84 + ((kac_saat - 300) * 5);
            }
            string cevap = String.Format("{0} saat için toplam ücretiniz = {1} tl", kac_saat,ucret.ToString());
            Console.WriteLine(cevap);
            Console.ReadLine();
        }
    }
}
