using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOkul
{
    public class Student
    {
        // Entity framework nesneler üzerinden çalıştığı için burada bir nesne oluşturduk ve encapsulation(getter setter ile properties lerini belirledik.)
        public int Id { get; set; } //VERİTABANINDAKİ İLİŞKİLİ TABLO İLE AYNI ÖZELLİKLERE SAHİP OLMALI!!
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }
        public string Classroom { get; set; }
    }
}
