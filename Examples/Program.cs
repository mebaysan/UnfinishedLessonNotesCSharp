using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };   // integer değerlerden bir dizi ürettik
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("----------------------------------------");
            string[] isimler = { "enes", "ahmet", "necla", "dede", "dayı" };
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("Chapter : Deneme :P");
            int i = 1;
            while (i<=25)
            {
                Console.WriteLine("Pythondaki Döngü Gibi Bir şey ulan buu wihuu :P");
                i++;
            }
            Console.WriteLine("*************************************\n************************************");
            for (int a = 0; a <= 10; a++)
            {
                for (int b = 0; b <= 10; b++)
                {
                    Console.Write("{0} * {1} = {2}", a, b, (a * b));
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Monster canavar = new Monster { Life = 100, Armor = 120, Damage = 45 };
            Player oyuncu = new Player { Life = 90, Armor = 120, Damage = 35 };
            Console.WriteLine(canavar.Life > oyuncu.Life ? "Canavar yendi" : "Oyuncu yendi");
           

            Console.ReadLine();
        }
    }

    class Monster
    {
        public int Life { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }
        public void Attack()
        {
            Console.Write("Canavar Hasar Verdi");
        }
    }

    class Player
    {
        public int Life { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }

    }
}
