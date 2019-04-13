using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOkul
{ // genellikle kullanılan veritabanı sonuna 'context' getirilerek isimlendirme yapılır.
    public class EOkulContext : DbContext // entity framework kullanılması icin DbContext class'ından inherit edilmeli
    {
        public DbSet<Student> Students { get; set; } // Student class türünde Students bir db. ÖNEMLİ OLAN VERİTABANINDAKİ İLİŞKİLİ TABLO İLE DBSET'TEN OLUŞAN'IN ADI AYNI OLMALI('STUDENTS')
        public DbSet<Classroom> Classrooms { get; set; } // Classrooms adında bir db var mı diye veritabanına bakar.

    }
}
