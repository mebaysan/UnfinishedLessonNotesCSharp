using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new FileLogger(); // loglama operasyonumuzu rahatlattık, esnettik
            customerManager.Add();
            Console.ReadLine();

        }
    }

    class CustomerManager // CustomerManager adında bir Class
    {
        public ILogger Logger { get; set; } // properity belirledik. ILogger türünde Logger ürettik. Kullanım sırasında nasıl kullanacağımızı set ettik.
        public void Add() // İçinde Add methodu
        {
            Logger.log();
            Console.WriteLine("Customer Added!");
        }
    }
    class Logger // Logger adında bir class
    {
        public void Log() // İçinde Log methodu
        {
            Console.WriteLine("Logged to database!");
        }
    }

    class FileLogger : ILogger // Dosyaya loglama class'ı oluşturduk
    {
        public void log() // FileLogger class'ına log adında method verdik
        {
            Console.WriteLine("Logged to file");
        }
    }
    class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    interface ILogger // ILogger interface oluşturduk
    {
        void log();

    }
}
