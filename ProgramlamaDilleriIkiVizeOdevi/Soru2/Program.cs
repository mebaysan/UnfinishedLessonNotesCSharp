using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> sayilar = new List<double>();
            while (true)
            {
                Console.WriteLine("Ondalıklı bir sayı gir: ");
                double sayi = Convert.ToDouble(Console.ReadLine());
                if (sayi == -1)
                {

                    break;
                }
                else
                {
                    sayilar.Add(sayi);
                }


            }
            Program self = new Program();
            double buyuk_sayi = self.BuyukSayi(sayilar);
            double kucuk_sayi = self.KucukSayi(sayilar);
            //Console.WriteLine(String.Format("En büyük sayı -> {0}\nEn küçük sayı -> {1}", buyuk_sayi, kucuk_sayi));
            Console.WriteLine("En büyük sayı -> " + buyuk_sayi + "\nEn küçük sayı -> " + kucuk_sayi);
            Console.ReadLine();

        }
        public double BuyukSayi(List<double> liste)
        {
            double bSayi = liste[0]; 
            for (int i = 0; i < liste.Count - 1; i++)
            {
                if (bSayi <= liste[i])
                {
                    bSayi = liste[i];
                }
            }

            return bSayi;
        }
        public double KucukSayi(List<double> liste)
        {

            double kSayi = liste[0];

            for (int i = 0; i <= liste.Count - 1; i++)
            {
                if (liste[i] <= kSayi)
                {
                    kSayi = liste[i];
                }
            }

            return kSayi;
        }
    }
}
