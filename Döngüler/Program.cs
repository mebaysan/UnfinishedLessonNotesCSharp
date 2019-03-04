using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++) // bildiğimiz for döngüsü. döngü içinde i belirledik. değeri 1 oldu. <= 100 dedik. ve bunu sağladığı sürece 1 atsın (i++).
            {                           // i+2 ile i=i+2 yapsaydık tek sayılar yazardı. 
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished\n------------------------------------");      // pythondaki gibi \n bir alt satıra geçer
            int number = 100;
            while (number >= 0) // bildiğimiz while döngüsü. şart sağlandığı sürece döngü devam etsin demek
            {
                Console.WriteLine(number);
                number--;       // nasıl ++ bir arttırıyorsa -- de bir azaltır
            }
            Console.WriteLine("While Döngüsü Bitti Çünkü Sayı Şuan {0}\n-----------------------", number);
            int number2 = 10;
            do      // -> şart sağlanmasa bile do döngüsü mutlaka çalışacaktır.
            {
                Console.WriteLine(number2);
                number2--;

            } while (number2 >= 1);
            Console.WriteLine("do döngüsü bitti çünkü sayı şuan {0}\n-----------------------------", number2);
            string[] isimler = { "Enes", "Yusuf", "Yavuz" };
            foreach (var isim in isimler) // dizi temelli dataların dolaşılması(iterate) Daha çok veritabanından bir tablo çekildiğinde kulanılır.
            {       // isimler dizisinin bütün isimlerini döner
                Console.WriteLine(isim);

            }
            Console.WriteLine("foreach döngüsü bitti\nASAL SAYI BULMA");
            if (IsPrimeNumber(7)) // eğer IsPrimeNumber methoduna parametre verdik
            {
                Console.WriteLine("This is prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number3)
        {
            bool result = true;
            for (int i = 2; i < number3 - 1; i++)
            {
                if (number3 % i == 0)
                {
                    result = false;
                    i = number3;

                }
            }
            return result;
        }

    }
}
