using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList("Ankara","İzmir","İstanbul");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items) // T tipinde liste ile çalşışacağız dedik
        {
            return new List<T>(items);
        }
    }
    class Product
    {

    }
    interface IProductDal : IRepository<Product>
    {
        

    }
    interface ICustomerDal : IRepository<Customer> // sen bir IRepository'sin ve çalışma nesnen Customer'dır dedik.
    {
        

    }
    class Customer
    {

    }
    interface IRepository<T> // Generic oluşturmak için T-> type'dan gelir
    {
        List<T> GetAll(); // sana T tipinde bir nesne vereceğim dedik.
        T Get(int id);
        void Add(T entity); // entity -> genel bir isimdir. varlık demektir.
        void Update(T entity);
        void Delete(T entity);
    }
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
