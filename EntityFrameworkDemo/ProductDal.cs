using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product>GetAll()
        {
            using (ETradeContext context = new ETradeContext()) // ürünleri listelemek için. using -> blok bittiği anda garbıc collector beklemeden nesneyi zorla bellekten atıyoruz(dispose).
            {
                return context.Products.ToList(); // 
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext()) 
            {
                context.Products.Add(product); // içine verdiğimiz nesneyi ekliyor.
                context.SaveChanges(); // yaptığımız işlemleri commit ediyoruz.
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product); // context'e bu product üzerinden ilerle
                entity.State = EntityState.Modified; // Modified -> update eder
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
