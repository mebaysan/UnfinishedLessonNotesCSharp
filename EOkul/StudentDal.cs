using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOkul
{
   public class StudentDal
    {
        public List<Student> GetAll()
        {
            using (EOkulContext eOkulContext = new EOkulContext()) // Etradecontext -> pahalı bir nesne fazla yer kaplar.Using kullanmamızın amacı method bittikten sonra nesneyi dispose ediyoruz. yer kaplamıyor.
            {
                return eOkulContext.Students.ToList();
            }

        }
        public void Add(Student student)
        {
            using (EOkulContext eOkulContext = new EOkulContext()) 
            {
                eOkulContext.Students.Add(student);
                eOkulContext.SaveChanges();
                /*
                 * Aynı anlamda kullanılır.
                 var entitiy = context.Entry(product);
                 entity.State = EntityState.Added;
                 context.SaveChanges();
                 */
               
            }

        }
        public void Update(Student student)
        {
            using (EOkulContext eOkulContext = new EOkulContext())
            {
                var entity = eOkulContext.Entry(student); // context'e student üzerinden abone ol yani gönderilen student veritabanındaki student ile eşitlenir
                entity.State = EntityState.Modified; // eşitledi/modifiye etti/güncelledi
                eOkulContext.SaveChanges();

            }

        }
        public void Delete(Student student)
        {
            using (EOkulContext eOkulContext = new EOkulContext())
            {
                var entity = eOkulContext.Entry(student); // context'e student üzerinden abone ol yani gçnderilen student veritabanındaki student ile eşitlenir
                entity.State = EntityState.Deleted; // sildi
                eOkulContext.SaveChanges();

            }

        }
    }
}
