using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOkul
{
    public class ClassroomDal
    {
        public List<Classroom> GetAll()
        {
            using (EOkulContext eOkulContext = new EOkulContext()) // Etradecontext -> pahalı bir nesne fazla yer kaplar.Using kullanmamızın amacı method bittikten sonra nesneyi dispose ediyoruz. yer kaplamıyor.
            {
                return eOkulContext.Classrooms.ToList(); // datagridviewClass adlı dgw'de eokulcontext nesnesindeki Classrooms nesnesini listeye çevirerek listeledik.


            }
        }
        public void Add(Classroom classroom)
        {
            using (EOkulContext eOkulContext = new EOkulContext())
            {
                eOkulContext.Classrooms.Add(classroom);
                eOkulContext.SaveChanges();

            }

        }
        public void Delete(Classroom classroom)
        {
            using (EOkulContext eOkulContext = new EOkulContext())
            {
            //    StudentDal studentDal = new StudentDal();
            //    List<Student> studentItem = studentDal.GetAll().Where(w => w.c == classroom.Id).ToList();

                var entity = eOkulContext.Entry(classroom);
                entity.State = EntityState.Deleted;
                eOkulContext.SaveChanges();



            }
        }
        
    }
}
