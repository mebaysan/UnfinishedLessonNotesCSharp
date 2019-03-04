using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Tipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World..."); // -> C# yorum satırı.  Konsola string bastırmaya yarar.
            // Veri Tipleri
            int number1 = 2147483647;   // değişken atadık.
            long number2 = 2147483648;  // int sınırlarının aşıldığı yerlerde kullanılır. ancak çok daha fazla yer kaplar bellekte.
            short number3 = -32768;     // -32768 ile 32767 arasında
            byte number4 = 0;       // 0 ile 255 arasında veri tutabildiğimiz veri tipidir.
            bool condition = true;     // mantıksal değerdir. true veya false değeri alır.
            char character = 'A';    // içine karakter ( klavye ile basılan tuş) atanır. tek tırnak içinde yazılır.
            double number5 = 10.4;            // ondalıklı sayılar tutulur. Pythonda ki float.
            decimal number6 = 10.9m;      // rakam sonuna koyulan m büyük küçük olablr. // hassar veriler için(ör: para) virgülden sonra 25 adet değer tutabilir
            var number7 = 10;           // değişkene atadığımız verinin tipi algılanır. var değişkenine sonradan atanan herşey ilk atanan değer tipinde işlem görür. Kısaca burda tip atarız.
            string str1 = "Hello World...";
            Console.WriteLine("Number1 is {0}",number1);  // ekrana değer bastırmak için parametre olarak değeri veririz.Aslında burda formatlama işlemi yaptık. virgülden sonra gelen 0. değeri koy. int sınırları -2147483648 ile 2147483647 arası
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Condititon is {0}", condition);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("int veri tipine dönüşmüş olan character {0}", (int)character);  // ASCII olarak dönüşür
            Console.WriteLine("String olan str1 -> {0}", str1);
            Console.ReadLine();  // Konsolun açılıp kapanmamasını beklemesini sağlar
            
        }

    }
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday //enum sabitlerinin değeri 0'dan başlar. Sırayı değiştirmek istersek Monday=10(istediğimiz değer)
    }

}
