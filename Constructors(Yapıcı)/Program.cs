using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Yapıcı_
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();

            Product product = new Product();
            product.Name = "Birinci gösterim şekli";

            Product product2 = new Product { Id = 1, Name = "İkinci gösterim şekli :=)" };

            Product product3 = new Product(3,"Üçüncü Gösterim Constructor ile"); // aşağıda constructor ile oluşturduğumuz methodlarda

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;  // static nesne herkes için aynı işlemi yapar.

            Console.ReadLine();
        }
    }

    // Constructors -> Genel anlamda new'lendiğinde çalışşacak kod bloğu. Constructor ile sınıfın ihtiyaç duyduğu parametreleri göndermek için kullanabiliriz.Overload edebiliriz
    class CustomerManager
    {
        private int _count; // private bir field alt çizgi ile başlatılır. İsimlendirme standardı

        public CustomerManager(int count) // method halinde alt çizgi kullanılmaz
        {
            //_count = 15; -> overload. hiçbirşey yoksa 15 olacak.
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }

    }

    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id,string name) // parametre olarak id ve name istedik
        {
            _id = id; 
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger; // private olan _logger'i parametre ile gelen logger'e değiştir
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} Message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity)//  PersonManager base sınıf için parametrede aracılık yapıyor
        {

        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    static class Teacher  // static classlarda new'lemek mümkün değildir. Classlar static olduğu gibi methodlarda static olabliri.
    {
        public static int Number { get; set; }  // Static nesnede prop eklemek için başında 'static' olmalıdır.

    }
}
