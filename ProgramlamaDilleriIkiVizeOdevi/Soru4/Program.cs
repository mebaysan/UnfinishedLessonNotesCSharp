using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            double borc = 0;
            Program self = new Program();
            Dictionary<string, double> Romanlar = new Dictionary<string, double>
            {
                {"Kürk Mantolu Madonna" , 7.5},
                {"Malcolm X" , 15.4},
                {"Köle Olmayacağız" , 13.4}
            };
            Dictionary<string, double> DunyaKlasikleri = new Dictionary<string, double>
            {
                {"Simyacı" , 14.86},
                {"Suç ve Ceza" , 12},
                {"Şeker Portakalı" , 15.27}
            };
            Dictionary<string, double> ProgramlamaKitaplari = new Dictionary<string, double>
            {
                {"Python" , 39},
                {"C# İle Görsel Programlama" , 49},
                {"Java İle Nesne Tabalı Programlama" , 55}
            };
            while (true)
            {
                Console.Write("************Kitap Satış İşlemleri************\n1-) Roman\n2-) Dünya Klasikleri\n3-) Programlama Kitapları\n4-) Ücret Hesapla\n5-) Çıkış\n**********************\n");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçin: ");
                int islem = Convert.ToInt32(Console.ReadLine());
                if (islem == 1)
                {
                    double ucret = self.KitapGetir(Romanlar);
                    borc = borc + ucret;
                }
                else if (islem == 2)
                {
                    double ucret = self.KitapGetir(DunyaKlasikleri);
                    borc = borc + ucret;
                }
                else if (islem == 3)
                {
                    double ucret = self.KitapGetir(ProgramlamaKitaplari);
                    borc = borc + ucret;
                }
                else if (islem == 4)
                {
                    Console.WriteLine(String.Format("Toplam ödemeniz gereken fiyat = {0}", borc));
                    break;
                }
                else if (islem == 5)
                {
                    Console.WriteLine("Programdan çıkılıyor...");
                    break;
                }

            }
            Console.ReadLine();
        }
        public double KitapGetir(Dictionary<string, double> kitapListesi)
        {
            int sayac = 1;
            int sayac2 = 1;
            foreach (var kitap in kitapListesi)
            {
                Console.WriteLine(String.Format("{0}-) {1} : {2} tl", sayac, kitap.Key, kitap.Value));
                sayac++;
            }
            Console.Write("Almak istediğiniz kitap numarasını girin: ");
            int kitapNo = Convert.ToInt32(Console.ReadLine());
            double fiyat = 0.0;
            foreach (var kitap in kitapListesi)
            {
                if (kitapNo == sayac2)
                {
                    fiyat = kitap.Value;
                }
                sayac2++;
            }
            return fiyat;
        }
    }
}
