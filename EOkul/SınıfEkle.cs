using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOkul
{
    public partial class SınıfEkle : Form
    {
        public SınıfEkle()
        {
            InitializeComponent();
        }

        private void SınıfEkle_Load(object sender, EventArgs e)
        {

        }
        ClassroomDal _classroomDal = new ClassroomDal();
        private void btnClassroomAdd_Click(object sender, EventArgs e)
        {
            _classroomDal.Add(new Classroom
            {
                Name = txtClassroomAdd.Text
               

            });
            MessageBox.Show("Sınıf Başarıyla Eklendi!");
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
