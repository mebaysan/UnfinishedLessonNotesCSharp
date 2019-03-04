using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal // dal -> data access lair -> veri işlerini dal sınıfında yaparız genelde
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal   // uygulamanın bağımlılıklarını 0'a indirdik. 
    {
        public void Add()                       // aşağıda da görüldüğü gibi esnek bir yapı kurduk. ister sql ister oracle veri işlemi yapabiliriz.
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();

        }
        public void Update(ICustomerDal customerDal)  // verdiğimiz customerDal aslında beklenilen bir parametredir. Adını biz belirledik.
        {
            customerDal.Update();

        }

        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete();

        }
    }
}
