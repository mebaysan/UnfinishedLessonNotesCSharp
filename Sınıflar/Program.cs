using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflar
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); // CustomerManager classından customerManager değişkenini oluşturduk.
            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "Enes";
            customer.Id = 1;                        // Bu bir gösterim
            customer.LastName = "Baysan";
            customer.City = "İstanbul";
            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Ankara",
                FirstName = "Yusuf",
                LastName = "Baysan"      // Bu bir gösterim
            };
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }

    class CustomerManager // Pythondan bildiğimiz class mantığı 
    {
        public void Add() // Add() adında bir method oluşturduk
        {
            Console.WriteLine("Customer Added");  // Bu methodun amacı yazı yazdırmak
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");

        }
    }

    class Customer
    {
        public int Id { get; set; } // yukarda customer class ından oluşturduğumuz customer ve customer2 içinde belirlenen enes = set, FirstName = get  denk gelir
        private string _firstName;  // bu bir field dir
        public string FirstName
        {
            get { return "Mr." + _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }     // bunlar birer property dir. Özelliktir.
        public string City { get; set; }

    }
}
