using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{ // Attribute'lar nesneye anlam vermemizi sağlar
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Enes", LastName = "Baysan" };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty] //-> attribute koyduk(aşağıda oluşturduk)
        public string FirstName { get; set; }
        [RequiredProperty]
        [RequiredProperty] // 2 kere kullandık, AllowMultiple sayesinde
        public string LastName { get; set; }
    }

    class CustomerDal
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0} {1} {2} added! ", customer.Id, customer.FirstName, customer.LastName);
        }
    }
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field,AllowMultiple =true)] // -> Bu attribute propertylere eklenebilir dedik .Class deseydik sadece class'larda kullanabilirdik. '|' diyerek diyer Targetsleri set edebiliriz. AllowMultiple -> birden fazla kullanmamızı sağlar(true ise kullanlır, false ise kullanılmaz)
    class RequiredPropertyAttribute : Attribute // attribute olduğunu ifade ediyoruz.
    {
        
    }
}
