using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductDal productDal = new ProductDal();
            dataGridView1.DataSource = productDal.GetAll(); // DataSource diyerek bu grid formunun veri kaynağını productDal nesnesi yaptık.
        }
    }
}
