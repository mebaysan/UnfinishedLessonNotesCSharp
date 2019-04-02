using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StringIslemler
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string islem;
            int app = 0;
            Console.WriteLine("1-)   Şu sıradaki kelimeyi getir\n2-) Harfi başa alıp Cümleyi tersten yazdır\n3-)   Cümle başındaki ve sonundaki boşlukları sil\n   4-)Cümlede yer alan kelimelerin baş harflerini büyük yazdır\n5-) Bütün cümleyi tersten yazdır\n6-)  Cikis");
            while (app<1)
            {

                string cümle;
                Console.WriteLine("Cümle gir:");
                cümle = Console.ReadLine();
                Console.WriteLine("İşlem seçiniz :");
                islem = Console.ReadLine();
                if (islem == "1")
                {
                    string[] kelimeler = cümle.Split(' ');
                    Console.WriteLine("Kacinci siradaki kelime gelsin : ");
                    int kkelime = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(kelimeler[kkelime -1]);
                }
                if(islem == "2")
                {
                    string[] kelimeler = cümle.Split(' ');
                    Console.WriteLine("Kacinci siradaki kelime başa gelsin : ");
                    int kkelime = Convert.ToInt32(Console.ReadLine());
                    string dkelime = kelimeler[kkelime-1];
                    
                    Console.WriteLine(dkelime + cümle);
                }
                if(islem == "3")
                {
                    cümle.Replace(" ", "");
                    Console.WriteLine("Yeni cümle ->\n " + cümle);

                }
                if(islem == "4")
                {
                    string[] kelimeler = cümle.Split(' ');
                    string sonuc = "";
                    for (int i = 0; i <= kelimeler.Length - 1; i++)
                    {
                        string ilkharf = kelimeler[i].Substring(0, 1);
                        string sonrakiharfler = kelimeler[i].Substring(1);
                        string düzgün = ilkharf.ToUpper() + sonrakiharfler.ToLower();
                        sonuc += düzgün + " ";
                    }
                    Console.WriteLine(sonuc);


                }
                if(islem == "6")
                {
                    Console.WriteLine("Programdan Çıkılıyor...");
                    break;
                }
                if (islem == "5")
                {
                    for (int i = cümle.Length; i > 0; i--)
                    {
                        Console.Write(cümle.Substring(i - 1, 1));
                    }
                    Console.WriteLine(cümle);

                }
                
                
            }
            Console.Read();
        }
        

    }
}
