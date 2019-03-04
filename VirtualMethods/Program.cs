using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add() // -> virtual => override edilmesi gereken methodlarda kullanılır
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()        // farklı yöntemler deneyeceğimiz inheritance edilmiş classlar için virtual kullanılır.
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer:Database // Database'e ait methodları SqlServer üzerine de kullanabiliriz
    {
        public override void Add() // override edilmesi gereken methodlarda kullanılır -> override.  Temel methodları 'ezmek' için yapılan operasyon.
        {
            Console.WriteLine("Added by Sql Code"); // virtual kullandığımız için burda SqlServer class'ına özel bir değişiklik yaptık.
            //base.Add(); // base -> SqlServer'ın oluştuğu Database'i işaret eder
        }

    }
    class MySql:Database
    {

    }
}
