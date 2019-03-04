using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class KendiHataSınıfımız : Exception // KendiHataSınıfımız adlı class ı Exception'dan inherit ettik.
    {
        public KendiHataSınıfımız(string message):base(message) //constructor oluşturduk. Bunun sayesinde kendi message'imizi base message gönderebiliriz.
        {
           
        }
    }
}
