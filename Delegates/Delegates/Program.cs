using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{   // Delegate -> bir nevi elçi diyebiliriz.
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            MyDelegate myDelegate = customerManager.SendMessage; // -> myDelegate elçisi customerManager'in SendMessage fonksiyonuna elçilik yapar
            myDelegate += customerManager.ShowAlert; // -> bu delegeye diğer operasyonu da atadık
            myDelegate(); // -> delegeyi çağırdık ve işlem gerçekleşti
            myDelegate -= customerManager.SendMessage; // -> aynı şekilde bu delegeden operasyonu silebiliriz.
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2("enes"); // -> parametreli delege
            Func<int, int, int> add = Topla; // Func tipinde bir delege oluşturduk, <parametre tipi , parametre tipi , değer dönüş tipi>
            Console.WriteLine(add(3, 5));
            Func<int> getRandomNumber = delegate () // parametresiz func olduğu için sadece return değer dönüş tipini vermemiz yeterli
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber);// parametresiz method kullandık
            Console.ReadLine();
        }
        // FUNC İLE ÇALIŞMAK
        static int Topla(int x, int y) // Func delegeye atayacağımız method static olmalı!
        {
            return x + y;
        }
    }
   

    public delegate void MyDelegate(); // -> parametre almayan, return döndürmeyen ve void olan operasyonlara delegate deriz.
    public delegate void MyDelegate2(string kelime);
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
        public void SendMessage2(string kelime)
        {
            Console.WriteLine("Hello!" + kelime);
        }
    }

}