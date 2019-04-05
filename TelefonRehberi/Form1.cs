using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstwPersons.View = View.Details;
            lstwPersons.FullRowSelect = true;

            lstwPersons.Columns.Add("Ad", 70);
            lstwPersons.Columns.Add("Soyad", 70);
            lstwPersons.Columns.Add("GSM", 120);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = txtName.Text;
            person.SurName = txtSurname.Text;
            person.Gsm = txtGsm.Text;

            string[] bilgiler = { person.Name, person.SurName, person.Gsm  };

            lstwPersons.Items.Add(new ListViewItem(bilgiler));

            txtName.Clear();
            txtSurname.Clear();
            txtGsm.Clear();
        }
    }
}
