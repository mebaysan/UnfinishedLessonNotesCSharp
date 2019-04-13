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
    // CONNECTİON STRİNGLER APP.CONFIG DOSYASINA YAZILIR.!
    public partial class Form1 : Form
    {
       
        StudentDal _studentDal = new StudentDal(); // StudentDal class'tan bir nesne oluşturduk.
        ClassroomDal _classroomDal = new ClassroomDal();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ÖğrenciEkle öğrenciEkle = new ÖğrenciEkle();
            this.Hide();
            öğrenciEkle.Show();

        }
        
        public void Form1_Load(object sender, EventArgs e)
        {
            // Form1 açılış işlemi
            dgwStudent.DataSource = _studentDal.GetAll(); 
            dgwClass.DataSource = _classroomDal.GetAll(); // dwgStudent.DataSource'i _studentDal nesnesinin GetAll methodu ile döndürdük.
                        


        }

        public void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            // Update işlemi
            try // try bloğu içinde yapmamızın sebebi eğer kayıtlı öğrenci yok ise program kapanmasın, kullanıcıya uyarı versin.
            {
                ÖğrenciGüncelle öğrenciGüncelle = new ÖğrenciGüncelle(int.Parse(dgwStudent.CurrentRow.Cells[0].Value.ToString()));

                this.Hide();

                öğrenciGüncelle.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Lütfen Öğrenci Seçin veya Yeni Kayıt Girin!");
            }
           




        }
        
       

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                _studentDal.Delete(new Student
                {
                    Id = Convert.ToInt32(dgwStudent.CurrentRow.Cells[0].Value)

                });
                MessageBox.Show("Seçili Öğrenci Başarıyla Silindi!");
                dgwStudent.DataSource = _studentDal.GetAll();
            }
            catch
            {
                MessageBox.Show("Seçili Öğrenci bulunamadığından işlem gerçekleştirilemedi!");
            }

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            SınıfEkle sınıfEkle = new SınıfEkle();
            this.Hide();
            sınıfEkle.Show();
            
            
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            try
            {
                _classroomDal.Delete(new Classroom
                {
                    Id = Convert.ToInt32(dgwClass.CurrentRow.Cells[0].Value)
                });
                MessageBox.Show("Seçlili Sınıf Başarıyla Silindi!");
                dgwClass.DataSource = _classroomDal.GetAll();
            }
            catch
            {
                MessageBox.Show("Seçili sınıf bulunamadığından işlem gerçekleştirilemedi!\nLütfen sınıf ekleyin!");
            }
        }
        
    }
   
}
