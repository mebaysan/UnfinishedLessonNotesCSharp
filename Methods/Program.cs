using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(20);   // -> aşağıda yazdığımız methodun parametrelerini verdik
            Console.WriteLine(result);
            Console.WriteLine("******************");
            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);
            Console.WriteLine(result2); // Burda 130 yazdırır
            Console.WriteLine(number1); // Burda 20 gider ( ref number1 yazdığımız için 30'a geri döndü)
            Console.WriteLine("****************");
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 6));
            Console.WriteLine("********************");
            Console.WriteLine(Add4(2, 4, 5, 6, 7, 8));
            Console.ReadLine();
        }
        static void Add()  // -> method oluşturduk.
        {
            Console.WriteLine("Added!");  // -> methodun işlevini atadık. Pythondaki fonksiyonlara benzer.

        }

        static int Add2(int number1, int number2 = 30) // -> içine parametre aldı. Normal fonksiyonlarda bildiğimiz iş. Bu parametrelere denk gelen değerler gelecek. = verince eğer 2.değer gelmezse default 30 değerini kullan dedik.
        {       // -> void değilde int yazmamızın sebebi burda int bir işlem yaptıracağız. void git birşeyi yap demektir.
                // var result = number1 + number2;      // -> var result diyerek result değişkenine number1 + number2 sonucunu atadık.
                // return result;    // -> return ile sayısal ifadeye döndürürüz
            return number1 + number2;  // bu şekilde de olabilir. önce burda işlemi yapar int döndürürüz. sonra yukarda result değişkenine atarız.
        }
        static int Add3(ref int number1, int number2) // ref koymamızın sebebi pythondaki global değişken gibidir. ref keyword önemlidir. number1 değerini ref ile belirledik ve 30 yazdık
        {
            number1 = 30;               // ref'in birde out versiyonu vardır. işlevi aynıdır. farkı ise şudur; out içine verilen parametre methodun içinde bir kere set edilmelidir.
            return number1 + number2;


        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;


        }
        static int Multiply(int number1, int number2, int number3) // aynı isimdeki methodu tekrar yazdık. hiçbir sıkıntı olmaz. Method overload yaptık(aşırı yükleme) aynı method ister 2, isterse 3 parametre alablr.
        {
            return number1 * number2 * number3;


        }
        static int Add4(params int[] numbers)   // pythondaki *'lı args gibidir. istediğin kadar parametre verebileceğin anlamına gelir.
        {
            return numbers.Sum();  // .Sum() hazır fonksiyondur. Dizideki bütün sayıları toplar.

        }
    }
}
