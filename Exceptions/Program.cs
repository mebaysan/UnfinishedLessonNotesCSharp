using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try // Buraya hata olabilecek kodu yazıyoruz. Pythondaki try durumuna benzer.
            {
                string[] students = new string[3] { "Engin", "Enes", "Yusuf" };

                students[3] = "Ahmet";

            }
            catch(Exception exception) // Bu bloğa hata olursa ne yapacağımızı yazıyoruz. Hatanın türünü belirleyebiliriz. Exception sınıfından oluşan exception objesi oluşan hata değerini alır.
            {
                Console.WriteLine(exception.Message); // oluşan objenin özelliklerini proplarını kullanırız.
                
            }
            Console.WriteLine("\n");

            try // Bu bloğu dene
            {
                List<string> şehirler = new List<string>();
                şehirler.Add("Hakkari");
                şehirler.Add("Mersin");
                şehirler.RemoveAt(3);

        }
            catch (ArgumentOutOfRangeException hata) // eğer hata alırsan ve aldığın hatanın türü ArgumentOutOfRangeException ise bu bloğu yap.
            {
                Console.WriteLine(hata.Message);
                
            }
            catch(Exception hata2) // Eğer hata yukardaki değilse bu bloğu yap
            {
                Console.WriteLine("Başka hata");
            }
            Console.WriteLine("\n");


            List<string> öğrenciler = new List<string> { "Baysan", "Bozali", "Karabul" };
            try
            {
                if (!öğrenciler.Contains("Sarı")) // ! ile -> öğrenciler listesi içinde 'Sarı' yoksa dedik.
                {
                    throw new KendiHataSınıfımız("Kayıt Bulunamadı"); // throw ile hatayı fırlatıyoruz.
                }
                else
                {
                    Console.WriteLine("Kayıt Bulundu");
                }
            }
            catch (KendiHataSınıfımız hata3)
            {
                Console.WriteLine(hata3.Message);
            }
            Console.WriteLine("\n");
            
            Console.ReadLine();
        }
    }
}
