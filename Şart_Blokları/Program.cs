using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ctrl k + ctrl d = kod düzenle - ctrl k + ctrl c = kodları yorum satırı yap - ctrl k + ctrl u = yorum satırlarını geri al
namespace Şart_Blokları
{
    class Program           // ÖNEMLİ HATIRLATMA C# TA ELSE İF ELSE İF 'LERDEN SONRA ; KOYMA!!
    {
        static void Main(string[] args)
        {
            var number = 95;         // number değişkenine bir değer atadık
            //if (number < 15)        // pythondan farkı burada if else bloklarından sonra ; koyulmuyor.
            //{
            //    Console.WriteLine("Sayı 15'ten Küçük.");
            //}
            //else if (number == 17)      // pythondaki elif yerine geçer.
            //{
            //    Console.WriteLine("Number 17'dir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 15'ten Büyük.");

            //}
            //var number2 = 15;
            //Console.WriteLine(number2 == 10 ? "Number2 10'dur " : "Number2 10 değildir");  // Tek satır if komutu yazdık burada. ilk önce şartı yazdık ? if yerine, : else yerine geçti.
            //switch (number)
            //{
            //    case 10:     // tek şart belirliyoruz. switche attığımız değişken 10 ise alttaki satırı uygula
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:        // eğer 20 ise alttakileri uygula
            //        Console.WriteLine("Number is 20");
            //        break;      // sonlandır demek (pythondaki gibi)
            //    default:        // yukardakilerin hiç biri değilse alttakini yap. Bir nevi else gibi.
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}
            //if (number >= 0 && number <= 100)   //  && -> mantıksal operatördür. bildiğimiz 'and' operatörü. pythondaki and c#-> &&
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 100-200");
            //}
            //else if (number > 200 || number < 0)      // || -> mantıksal operatördür. pythondaki 'or' operatörü yerine geçer. "yada,veya" demektir.
            //{
            //    Console.WriteLine("Number is less than 0 or greater then 200");
            //}
            //else
            //{
            //    Console.WriteLine("Nasıl bir sayı seçtin lan :P");
            //}
            if (number < 100)
            {
                if (number >= 90 && number < 100)
                {
                    Console.WriteLine("İç içe if denemesi yaptık ama birşey farketmedi pythondaki if mantığı ile aynı :P");
                }
            }
            Console.ReadLine();
        }
    }
}
