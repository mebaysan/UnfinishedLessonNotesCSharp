using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{           // PYTHONDAKİ GİBİ İNT VE STR BİR DİZİ İÇİNDE OLAMAZ!!
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3]; // dizi tanımlama yöntemi
            students[0] = "Enes";
            students[1] = "Baysan";
            students[2] = "Yusuf";

            string[] students2 = new[] { "Enes", "Baysan", "Yusuf" }; // dizi tanımlama yöntemi

            string[] students3 = { "Enes", "baysan", "yusuf" };     // dizi tanımlama yöntemi
            foreach (var student in students3)    // pythondaki for döngüsü gibi düşün. student = i in liste = students3
            {       // var ile değerin tipini belirledik
                Console.WriteLine(student);     // yukardan gelen student değerlerini yaz dedik
            }
            Console.WriteLine("************************");
            string[,] regions = new string[5, 3] // 7 satır 3 sütun dedik ilk parametre satır ikinci parametre sütun
            {       // , koyarak çok boyutlu bir string ile çalışacağımızı söyledik
                { "İstanbul ","İzmit ","Balıkesir" },
                { "Ankara ","Konya ","Kırıkkale "},
                { "Antalya ","Adana "," Mersin"},
                { "Rize ","Trabzon ","Samsun "},
                { "İzmir ","Muğla ","Manisa "},
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++) // regions.GetUpperBound(0) diyerek ilk parametrenin en üst değerini yakalamayı istedik
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("***************");

            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
