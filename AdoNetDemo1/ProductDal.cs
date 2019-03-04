using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo1
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");  // sql bağlantısı için SqlConnection classından connection adlı obje.Pythondaki gibi.@ işaretinin anlamı -> tamamen bir string olarak kabul et dedik. \m'nin özel bir anlamı olduğundan.
                                                                                                                                          //server = diyerek bağlanacağımız db. initial catalog= diyerek hangi veritabanına bağlanacağımız. integrated security = true diyerek database'e bu bilgisayardan bağlanacağımızı söyledik. Uzaktaki bir veritabanına bağlanmak için false;uid=kullanici_adi;pwd=sifre deriz.
        public List<Product> GetAll() // ürünleri listeleyecek bir method
        {

            ConnectionControl(); // aşağıda yazdığımız methodu çağırdık.

            SqlCommand command = new SqlCommand("Select * from Products", _connection); //Burdada sql komutlarını çalıştırabilmek için SqlCommand adlı sınıftan bir cursor oluşturduk.Komutu yazdık ve hangi bağlantıya gönderileceğini yazdık.
            SqlDataReader reader = command.ExecuteReader(); // bu execute komutu çalıştırmak için reader adlı bir sınıf oluşturduk.
            List<Product> products = new List<Product>();
            // reader'deki ürünleri products içine atmak için aşağıya:
            while (reader.Read()) // reader içindeki herşeyi tek tek oku
            {
                Product product = new Product // okuyabildiği sürece herseferinde yeni bir product nesnesi
                {
                    Id = Convert.ToInt32(reader["Id"]), // Id'yi reader'den gelen Id değeriyle değiştir ve ToInt32 sayesinde bunu int değere çevir.Id product classındaki Id.
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product); // okuduğumuz her elemanı(product) products listesine ekle dedik.
            }

            reader.Close(); // işimiz bittiği için cursor'u kapattık
            _connection.Close(); // bağlantıyı kapattık
            return products; // değeri döndürdük
        }
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed) // sql bağlantısını açmak için bir if durumu ile kontrol ettik. Bağlantıyı tekrar tekrar açmak sıkıntı oluşturabilir.
            {
                _connection.Open(); // bağlantıyı açtık. Pythona benzer
            }
        }
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)", _connection); // @name vs yazmamızın sebebi pythondaki gibi bir nevi inputla alacağımız için values kısmına bu aldığımız değerlerin gelmesi.
            command.Parameters.AddWithValue("@name", product.Name); // parametre olduğunda her zaman .Parameters.AddWithValue diyoruz. aldığımız @name değeri product.Name yerine geçecek.
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery(); // reader yerine insert yaparken nonquery yazılır.
            _connection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Name= @name,UnitPrice=@unitPrice,StockAmount=@stockAmount where Id=@id", _connection); // @name vs yazmamızın sebebi pythondaki gibi bir nevi inputla alacağımız için values kısmına bu aldığımız değerlerin gelmesi.
            command.Parameters.AddWithValue("@name", product.Name); // parametre olduğunda her zaman .Parameters.AddWithValue diyoruz. aldığımız @name değeri product.Name yerine geçecek.
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery(); // reader yerine insert yaparken nonquery yazılır.
            _connection.Close();
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete From Products where Id=@id", _connection); // delete işlemini id üzerinden yapacağız
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

    }
}
