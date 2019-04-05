using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class Person
    {
        private string name;
        private string surName;
        private string gsm;

        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public string Gsm { get => gsm; set => gsm = value; }
    }
}
