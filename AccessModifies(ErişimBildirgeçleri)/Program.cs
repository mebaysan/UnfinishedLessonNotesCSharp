using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifies_ErişimBildirgeçleri_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        private int Id;  // private bir değişken sadece tanımlandığı blok içerisinde geçerlidir. Student Class'ında Id'ye erişemeyiz.
        protected string FirstName; // protected değişkenin privatenin tek farkı inherit edildiği sınıflarda da  kullanılır.
        public void Save()
        {
                   
        }
    }
    class Student:Customer
    {
        public void Save()   // void method oluştururken kullanılır.
        {
            Customer customer = new Customer();
            
            
        }

    }

    class Course // Herhangi bir class'ın default accessmodifie'i internal'dır. -> internal class Course
    {           // internal bir class'ın özelliği, bağlı bulunduğu proje içerisinde referans ihtiyacı olmadan kullanabilirsiniz.Yani bütün classları
        public string Name { get; set; }
    }

    class PublicSınıf  //  public accessmodifier ise public olan öğeye heryerden erişilebilmesini sağlar.Yandan eklenecek projeye eklenir ve yukarı using ProjeAdi.cs olarak yazılır.
    {
        public string LastName { get; set; }
    }
}

