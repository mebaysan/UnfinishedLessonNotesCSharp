using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem(2, 3);
            Console.WriteLine(dortIslem.Topla(5, 6)); // -> parametre olarak aldığı değerler ile çalışıyor
            Console.WriteLine(dortIslem.Topla2()); // -> constructor daki değerler ile çalışıyor

            var tip = typeof(DortIslem); // -> benim çalışacağım bir tip var ve bu DortIslem'dir dedik.

            DortIslem dortIslem2 = (DortIslem) Activator.CreateInstance(tip,8,9); // -> 8,9 diyerek constructor parametrelerini verdik
            //tip.GetType().GetMethod("Topla2").Invoke(tip,null); // -> GetMethod ile istediğimiz methoda ulaşırız, Invoke diyerek o methodu çalıştırırız.

            var metodlar = tip.GetMethods(); // methodları metodlar diye bir listede topladık
            foreach (var item in metodlar)
            {
                Console.WriteLine("Metod Adı : {0}", item.Name);
                foreach ( var parametre in item.GetParameters()) // her item nesnesinin Parametresi için
                {
                    Console.WriteLine("Parametre = {0}", parametre.Name);
                }
                foreach (var attribute in item.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }
            }
            Console.ReadLine();
        }
    }


    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;


        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }
}
