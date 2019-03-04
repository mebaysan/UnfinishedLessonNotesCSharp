using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//INHERITANCE VE INTERFACE KARIŞIMI BİR CLASS
namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer(); // Interface gibi , abstract classında tek başına anlamı yoktur.
            sqlServer.Add();
            sqlServer.Delete();
            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add() // Burda demek istedik ki; Db ekleme işlemi heryerde aynı
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete(); // ancak silme işlemi heryerde aynı değildir.(Örnek olarak yoksa öyle birşey yok :P), yarım method denir.
        
    }
    class SqlServer : Database // Database baba class'tan yavru bir SqlServer class oluşturduk.
    {
        public override void Delete() // Ve burada sadece bize abstract delete methodu geldi. Bunun sebebi ise zaten yukarda biz Add methodunu her sınıf için aynı olacak dedik, ancak delete methodu her sınıfta farklı olacak dedik. Bu sebepten ötürü sadece delete methodu geldi.
        {
            Console.WriteLine("Farklı olan silme işlemini yaptık burada...");
        }
    }

}
