using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product {Name=tbxName.Text,UnitPrice=Convert.ToDecimal(tbxUnitPrice.Text),StockAmount=Convert.ToInt32(tbxStockAmount.Text) });
            LoadProducts();
            MessageBox.Show("Added Successfully!");


        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll(); // yazdığımız getall methodunu çalıştırdık. Bir method yaptık yukarda işler kolaylaşsın diye.
        }

        private void SearchProducts(string key) // aramabutonuyla içinde textbox'a verilen değeri aramasını söyleyen kod bloğu
        {
            var result  = _productDal.GetAll().Where(p=>p.Name.Contains(key)).ToList(); // result adlı değişkene atadık.
            dgwProducts.DataSource = result;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value), // id değişmesini istemediğimiz için gridden aldık.
                Name = tbxNameUpdate.Text, // yeni gelecek olan değeri update kısmındaki textboxtan aldık.
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)

            });
            LoadProducts();
            MessageBox.Show("Updated Successfully!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString(); // CurrentRow -> seçili olan satır. Cells[1] o satırın 1. sütunu. Value.ToString -> değerini stringe çevir.
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product {

                Id=Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)

            });
            LoadProducts();
            MessageBox.Show("Deleted Successfully!");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text); // içine gelen değeri aramasını söyledik
        }
    }
}
