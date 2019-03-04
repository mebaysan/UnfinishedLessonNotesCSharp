using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringler
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara";
            Console.WriteLine(city, "\n-------------------");
            foreach (var item in city)
            {
                Console.WriteLine(item); // Burda foreach döngüsü sayesinde indexleme yaptık diyebiliriz. city değişkenindeki her bir karakter bir index geldi.
            }
            string city2 = "İstanbul";
            // string result = city + city2;   -> bunu dersek bellekte boş yere bir değer daha tutmuş olacağız.
            Console.WriteLine(String.Format("{0} {1}", city, city2));  // iki string değerini birleştirdik. Pythondaki formatlama işleminin aynısı.
            Console.WriteLine("Stringlerdeki Methodlar..");

            string sentence = "My name is Baysan";
            var result = sentence.Length;       // .Length properity'si bize içine verilen stringin kaç karakterden oluşuğunu verir.
            Console.WriteLine("'My name is Baysan' {0} karakterden oluşur.", result);
            var result2 = sentence.Clone();   // .Clone() methodu bize üstünde kullandığımız değerin aynısını oluşturur.
            Console.WriteLine(result2);
            bool result3 = sentence.EndsWith("g"); // Pythondan bildiğimiz .EndsWith("harf"); methodu üstünde kullandığımız değer parametreye verilen harf/kelime ile bitiyor mu demektir. Sonuç bool ile döndürülür. Doğruysa True değilse False
            Console.WriteLine("My name is Baysan 'g' ile bitiyor mu ? {0}",result3);
            bool result4 = sentence.StartsWith("My");   // string içine verilen harf/kelime ile başlıyor mu?
            Console.WriteLine(result4);
            var result5 = sentence.IndexOf("name"); // .IndexOf üstünde kullandığımız değişkende parametre var mı yok mu diye sorar. Yoksa -1 döndürür. Birden fazla aynı değer varsa ilk bulduğu yerde bırakır.
            Console.WriteLine(result5);
            var result6 = sentence.LastIndexOf("M"); // Aramaya sondan başlar.
            Console.WriteLine(result6);
            var result7 = sentence.Insert(0, "Hello, ");    // Pythondan Bildiğimiz insert methodu. İlk verilen parametre kaçıncı indexten başlayacak, ikinci parametre ise ekleyeceği string dir.
            Console.WriteLine(result7);
            var result8 = sentence.Substring(3,4);            // İçine verilen parametreden itibaren stringi parçalar. ikinci parametre opsiyoneldir. ikinci parametre = başladığın yerden itibaren verilen parametre kadar al demek.
            Console.WriteLine(result8);
            var result9 = sentence.ToLower();           // Bütün karakterleri küçük harfe çevirir. Pythondaki gibi. Bunun upper versiyonu da vardır.
            Console.WriteLine(result9);
            var result10 = sentence.Replace(" ","-");   // Pythondan bildiğimiz replace methodu. İlk parametre değiştirilecek karakter, ikinci parametre neyle değiştirileceğidir.
            Console.WriteLine(result10);
            var result11 = sentence.Remove(2,4);      // içine verilen parametreden itibaren harfleri atar. ikinci parametre opsiyoneldir. İkinci parametreden itibaren ikinciparametre kadar harfi at.
            Console.WriteLine(result11);
            Console.ReadLine();
        }
    }
}
