using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listeler
{
    class Program
    {
        static void Main(string[] args)
        { // Tip güvenli koleksiyon yapısı -> List<int> collec_adi = new List<int>  ->-> int yerine diğer veri tipleri gelebilir. Bu sayede sadece o tiple çalışırız.
            List<string> günler = new List<string>(); // bir liste oluşturduk. Liste ile diziler arasındaki en önemli fark -> Listelerde içine alacağı eleman sayısı sınırsızdır. Dizilerde belirtiyoruz.

            günler.Add("Pazartesi"); // Pythondaki gibi listeye eleman ekledik.
            günler.Add("Salı");
            günler.Add("Çarşamba");

            Console.WriteLine(günler[0]); // Günler listesinin ilk indeksini istedik.
            Console.WriteLine("Günler Listesini foreach döngüsü ile yazdık.");
            Console.WriteLine("\n\n");
            foreach (var gün in günler)
            {
                Console.WriteLine(gün);
            }
            Console.WriteLine("\n");
            Console.WriteLine(günler.Count()); // günler listesi içinde kaç adet eleman olduğunu söyler.
            Console.WriteLine("\n");
            günler.Remove("Salı");  // Remove methodu içine verilen değeri listeden silmemizi sağlar.
            foreach (var item in günler)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("\n");
            günler.RemoveAt(0); // RemoveAt methoduna parametre olarak verdiğimiz indexi siler.
            foreach (var item in günler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            günler.Clear(); // listeyi silip boşaltmaya yarar
            Console.WriteLine("Clear methodu sayesinde listedeki eleman sayısı {0}", günler.Count());
            //günler.Add("Pazartesi");
            günler.Add("Salı");
            günler.Add("Çarşamba");
            günler.Add("Perşembe");
            Console.WriteLine("\n");
            if (günler.Contains("Pazartesi")) // Listede eleman arattık. Contains methodu içine parametre olarak yolladık. if ve else bloklarda şartları sunduk. if else koymazsak varsa true yoksa false döndürür.
            {
                Console.WriteLine("Pazartesi listede var");
            }
            else
            {
                Console.WriteLine("Pazartesi Listede yok");
            }

            Console.WriteLine("\n");
            günler.Reverse(); // Listeyi ters çevirir.
            foreach (var item in günler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
            // Listeyi bir class türüne göre oluşturmak
            List<Customer> customers = new List<Customer>(); // customers adında bir liste oluşturduk ve elemanları Customer Class'ına göre olsun dedik.
            customers.Add(new Customer { Id = 1, FirstName = "Enes" }); // Customer Class'ta belirlediğimiz proplara göre eleman eklerken aynı zamanda da özelliklerini belirledik.
            customers.Add(new Customer { Id = 2, FirstName = "Yusuf" });
            foreach (var item in customers)
            {
                Console.WriteLine("Customer Id = {0} ve Customer FirstName = {1}", item.Id, item.FirstName);// Bu döngüde içerdeki her bir eleman item adını aldığı için item.Id ve item.FirstName diyerek proplarını yazdırdık.
            }
            Customer deneme = new Customer { Id = 3, FirstName = "Deneme" }; // Customer classından deneme adında bir obje oluşturduk.
            customers.Add(deneme); // yukardaki customers listesine oluşturduğumuz deneme objesini ekledik.Gösterim amaçlı.
            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine("\n");
            customers.AddRange(new Customer[2] // AddRange olarak içine bir liste verebiliriz veya dize(array) verebiliriz.
                {
                    new Customer{Id=4,FirstName="Ali"},
                    new Customer{Id=5,FirstName="Baba"}
                });
            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine("\n");
            var kacinci_sira = customers.IndexOf(deneme); // deneme adlı objemizin kaçıncı sırada olduğunu bir değişkene atadık. IndexOf() içine verilen parametrenin kaçıncı sırada olduğunu verir. 
            Console.WriteLine("deneme adlı obje koleksiyonda {0}. sırada", kacinci_sira);
            Console.WriteLine("\n");
            var xkacinci_sira = customers.LastIndexOf(deneme); // deneme adlı objemizin kaçıncı sırada olduğunu bir değişkene atadık. LastIndexOf() içine verilen parametrenin kaçıncı sırada olduğunu verir.Tersten arar. 
            Console.WriteLine("deneme adlı obje koleksiyonda {0}. sırada", xkacinci_sira);
            Console.WriteLine("\n");
            customers.Insert(0, new Customer { Id = 10, FirstName = "InsertleGeldi" }); // Insert metodu kaçıncı sıraya ne ekleyeceğimizi söylüyor. Yeni bir customer ekledik
            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine("\n");
            // deneme3 adında bir obje oluşturduk. Özelliklerini belirledik. Ve Insert sayesinde customers listesine ekledik.
            Customer deneme3 = new Customer { Id = 11, FirstName = "Deneme3" };
            customers.Insert(0, deneme3);
            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine("\n");
            customers.RemoveAll(c => c.FirstName == "Deneme"); // burda dedik ki -> firstname'i Deneme olanların hepsini sil.
            // ARRAYLİST kavramı. ArrayList tercihi ne zaman yapılmalı -> eğer illa bir veri tipi ile çalışacağız demiyorsak(string,int,byte,long,vs..) ArrayList ile çalışılır. Bütün değerleri alır. Bu işleme 'Type Safe' denir.
            ArrayList cities = new ArrayList(); // temel bir collection  tipi
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add("Ardahan");
            cities.Add("Kars");
            Console.WriteLine(cities[2] + "\n"); // 2. indeksi yaz dedik. pythonda , ile birleştirdiğimiz indeksler burda + ile birleşir
            cities.Add(1);
            cities.Add("B");
            foreach (var item in cities)
            {
                Console.WriteLine(item + "\n**");
            }
            Console.WriteLine("\n");
            // Dictionary-Sözlükler -> Anahtar kelimeler ile bir değere ulaşmak istediğimiz collectionslardandır. Pythondaki sözlüklere benzer.
            Dictionary<string, string> dictionary = new Dictionary<string, string>(); // dictionary adında bir sözlük oluşturduk. string,string diyerek anahtarı string karışık gelen değeri de string demiş olduk.
            dictionary.Add("book","kitap"); // book -> key, kitap -> value
            dictionary.Add("table","masa");
            dictionary.Add("computer","masa");
            Console.WriteLine(dictionary["table"]); // yazdırmak için anahtar değeri veririz.
            Console.WriteLine("\n");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value); //.Value diyerek değere, .Key diyerek anahtara, item diyerek hem anahtara hem değere ulaşırız.
            }
            Console.WriteLine("\n");
            Console.WriteLine(dictionary.ContainsKey("glass")); // ContainsKey içine parametre olarak yolladığımız anahtar değer var mı yok mu onu döndürür. aynısı Value içinde geçerlidir.
            Console.ReadLine();
        }

    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }

}
