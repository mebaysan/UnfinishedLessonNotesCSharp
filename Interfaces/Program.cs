using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer deneme = new Customer();
            deneme.Id = 1;
            deneme.FirstName = "Enes";  // Burası da bir class tanımlama yöntemi
            deneme.LastName = "Baysan";
            deneme.Adress = "Bahçetepe/Başakşehir";
            Console.WriteLine("Customer Class Özellikleri :\nAdı = {0}\nSoyadı = {1}\nId'si = {2}\nAdresi = {3}\n\n\n", deneme.FirstName, deneme.LastName, deneme.Id, deneme.Adress);
            PersonManager manager = new PersonManager();
            Customer customer2 = new Customer { Id = 2, FirstName = "Yususf", LastName = "Baysan", Adress = "İstanbul" }; // Bir class tanımlama yöntemi
            manager.Add(customer2);  // PersonManager classından oluşturduğumuz manager değişkeninin alt satırlarda oluşturduğumuz Add methodu ile işlem yaptık.
            CustomerManager customerManager = new CustomerManager(); // customerManager objesi oluşturduk.
            customerManager.Update(new SqlServerCustomerDal()); // oluşturduğumuz objeyi .Add methodu ile sql servere ekledik(örnek)
            Console.WriteLine("\n*********\n*******");
            // PolyMorphism
            ICustomerDal[] customerDals = new ICustomerDal[2] { new SqlServerCustomerDal(), new OracleServerCustomerDal() }; // ICustomerDal türünde array tanımladık. 2 elemanlı olacak dedik. İlk elemanı : sql, ikinci elemanı : oracle
            foreach (var customerDal in customerDals) // 2 elemanı da gezdik ve her biri için add metodunu uyguladık.
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }

        interface IPerson // soyut bir kavramdır. Üst düzey bir class diyebiliriz.
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson    // somut bir kavramdır - IPerson Interface'sinden Customer Class oluşturduk
        {
            public int Id { get; set; }     // Burda IPerson Customer ın IPerson olduğu için aldığı özellik
            public string FirstName { get; set; }    // Burda IPerson Customer ın IPerson olduğu için aldığı özellik
            public string LastName { get; set; }    // Burda IPerson Customer ın IPerson olduğu için aldığı özellik
            public string Adress { get; set; }  // Burda Class olarak Customer 'ın aldığı özellik

        }
        class Student : IPerson   // encapsulation
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }

        }
        class PersonManager
        {
            public void Add(Customer customer)
            {
                Console.WriteLine("Evet {0}'nin Kaydı Başarılı...", customer.FirstName);


            }
        }
    }
}
