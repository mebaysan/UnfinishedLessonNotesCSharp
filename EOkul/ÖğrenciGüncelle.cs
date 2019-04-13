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
    public partial class ÖğrenciGüncelle : Form
    {
        int id = 0;
        public ÖğrenciGüncelle(int id) // constructor içine id istedik
        {
            this.id = id; // formun id'sini parametre olarak gelen id'ye eşitledik.

            InitializeComponent();
        }

        public string Name { get; set; }
        
        

        public static void ActiveForm()
        {
            throw new NotImplementedException();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            StudentDal studentDal = new StudentDal();
            studentDal.Update(new Student
            {
                Id = Convert.ToInt32(this.id), // güncelleme işlemi olduğu için burada id'de vermeliyiz
                Name = txtNameStudentUpdate.Text,
                Surname = txtSurnameStudentUpdate.Text,
                Number = Convert.ToInt32(txtNumberStudentUpdate.Text),
                Classroom = cbxClassrooms.Text
            });
            MessageBox.Show(String.Format("{0} id'li öğrenci başarıyla güncellendi!", this.id.ToString()));
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void ÖğrenciGüncelle_Load(object sender, EventArgs e)
        {
            ClassroomDal classroomDal = new ClassroomDal();
            StudentDal studentDal = new StudentDal();
            List<Student> studentItem = studentDal.GetAll().Where(w => w.Id == id).ToList(); // linq ile sorgu attık.
            txtNameStudentUpdate.Text = studentItem[0].Name; // textbox'ın text'ini studentItem[0]'ın name'ine eşitledik.
            txtSurnameStudentUpdate.Text = studentItem[0].Surname;
            txtNumberStudentUpdate.Text = Convert.ToString(studentItem[0].Number);
            cbxClassrooms.Text = studentItem[0].Classroom;
            cbxClassrooms.DataSource = classroomDal.GetAll();
            cbxClassrooms.DisplayMember = "Name";
            this.Name = studentItem[0].Name;

        }
    }
}
