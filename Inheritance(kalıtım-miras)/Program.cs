using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_kalıtım_miras_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3] // array verdik. Person class'tan 3 adet Person oluşacak dedik.
            {
                new Customer{FirstName="Enes" }, new Student{FirstName="Baysan" }, new Person{FirstName="Yusuf" }      // Person Class'tan 3 adet obje oluşturduk. Customer,Student,Person. ** Interface yönteminde interface tek başına anlam ifade etmiyordu ancak Inheritance yönteminde class tek başına anlam ifade eder.
            };
            foreach (var person in persons)  // foreach döngüsü sayesinde 'persons' dizisindeki bütün elemanları gezdik.Burda rahatlık Customer ve Student'ın Person class'tan oluşmasıydı 
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }

    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person // Inheritance kalıtım yaptık. Yani sen bir Person 'ın dedik. 
    {
        public string City { get; set; } // Burası da Customer class'ına özel bir properitydir.

    }
    
    class Student:Person // Inheritance yaptığımız yeni class sadece bir adet Inheritance alabilir. Ancak birden fazla Interface yapılır

    {
        public string Departmant { get; set; }

    }
}
