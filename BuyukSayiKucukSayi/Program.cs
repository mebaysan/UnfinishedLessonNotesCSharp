using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukSayiKucukSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            Random random = new Random();
            for(int i=1; i <= 15; i++)
            {
                int x = random.Next(3, 2900);
                sayilar.Add(x);
            }
            Program program = new Program();
            int ksayi = program.KucukSayi(sayilar);


            Console.WriteLine("İcerdeki en büyük sayi = " + ksayi);

            Console.ReadLine();
        }

        public int BuyukSayi( List<int> liste)
        {
            int bSayi = 0;
            foreach(var sayi in liste)
            {
                if (bSayi <= sayi)
                {
                    bSayi = sayi;
                }
            }
            
            return bSayi;
        }
        public int KucukSayi( List<int> liste)
        {
            int kSayi = 0;
            foreach (var sayi in liste)
            {
                if (kSayi >= sayi)
                {
                    kSayi = sayi;
                }
                else
                {
                    kSayi = sayi;
                }
            }
            Console.WriteLine("İcerdeki en kücük sayi = " + kSayi);

            return kSayi;
        }
    }
}
