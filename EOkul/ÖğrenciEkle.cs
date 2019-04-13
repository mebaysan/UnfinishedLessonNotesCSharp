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
    public partial class ÖğrenciEkle : Form
    {
        public ÖğrenciEkle()
        {
            InitializeComponent();
        }
        StudentDal _studentDal = new StudentDal();
        private void btnAddStudent2_Click(object sender, EventArgs e)
        {
            _studentDal.Add(new Student
            {
                Name = txtNameStudent.Text,
                Surname = txtSurnameStudent.Text,
                Number = Convert.ToInt32(txtNumberStudent.Text),
                Classroom = cbxClassrooms.Text
            });
            
            MessageBox.Show("Öğrenci Başarıyla Eklendi!");
            this.Hide(); // burada bu forma veri taşımakla uğraşmamak için this.Hide diyerek ÖğrenciEkle formunu kapattık
            Form1 frm1 = new Form1(); // Form1 class'tan frm1 nesnesi oluşturduk
            frm1.Show(); // ve frm1.Show diyerek frm1 nesnesini tekrar başlattık böylece nesneler tekrar yüklenmiş oldu.

            
            
        }
        ClassroomDal _classroomDal = new ClassroomDal();
        private void ÖğrenciEkle_Load(object sender, EventArgs e)
        {
            cbxClassrooms.DataSource = _classroomDal.GetAll();
            cbxClassrooms.DisplayMember = "Name"; // datasource'a komple veritabanını ekledik ama hangi alanlarının yükleneceğini seçmedik. DisplayMember methodu ile parametre olarak verdiğimiz değere karşılık gelen tablodaki kolonu basar.

        }
    }
}
