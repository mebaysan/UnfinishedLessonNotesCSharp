using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal(); // ProductDal classtan bir productDal nesnesi
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            //dgwProducts.DataSource = _productDal.GetAll(); // datagridview objesinin DataSource methodu sayesinde verilerin nerden geleceğini söyledik. productDal objesinin GetAll fonksiyonu ile verileri gösterdik.
        }
        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void btnAdd_Click(object sender, EventArgs e) // event belirledik butona tıklayınca ne olacağını seçtik.
        {
            _productDal.Add(new Product // _productDal nesnemizin Add methodunu çağırdık
            {
                Name = tbxName.Text, // product nesnesinin özelliklerini belirledik.
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            MessageBox.Show("Product Added"); // mesaj verdik.
            //dgwProducts.DataSource = _productDal.GetAll(); // bunun daha güzel gözükmesi için bu işlemi bir method haline getirebiliriz.
            LoadProducts();
        }

       

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString(); // CurrentRow -> seçili olan satır. Cells[1] o satırın 1. sütunu. Value.ToString -> değerini stringe çevir.
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e) // update butonuna tıklayınca ne olacağını yazıyoruz.
        {
            Product product = new Product // bir product nesnesi oluşturduk ve özelliklerini belirledik.
            {
                Id =Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value), // id değişmesini istemediğimiz için gridden aldık.
                Name = tbxNameUpdate.Text, // yeni gelecek olan değeri update kısmındaki textboxtan aldık.
                UnitPrice =Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)

        };
            _productDal.Update(product); // update methodunu çağırdık
            MessageBox.Show("Updated!");
            LoadProducts();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            MessageBox.Show("Deleted!");
            LoadProducts();

        }
    }
}
