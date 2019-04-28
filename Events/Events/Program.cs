using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product laptop = new Product(50);
            laptop.ProductName = "Laptop";
            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent; // event'e kayıt olduk!
            for (int i = 0; i < 10; i++)
            {
                laptop.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Gsm about to finish!");
        }
    }
    public delegate void StockControl();
    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent; // event oluşturduk
        public string ProductName { get; set; }
        public int Stock {
            get { return _stock; }
            set {
                _stock = value;
                if (value<=15 && StockControlEvent!=null)
                {
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{0} Stock Amount = {1}",ProductName, Stock);
        }
    }
}
