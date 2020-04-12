using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeÖdevi5.Soru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Hesapla()
        {
            int tutar = 0;
            if (checkBox1.Checked)
            {
                tutar = tutar + 525;
            }

            if (checkBox2.Checked)
            {
                tutar = tutar + 3228;
            }

            if (checkBox3.Checked)
            {
                tutar = tutar + 1021;
            }

            if (checkBox4.Checked)
            {
                tutar = tutar + 5532;
            }

            label7.Text = tutar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, telefon, adres,semt, cnsyt="",siparis="";
            ad = textBox1.Text;
            telefon = maskedTextBox1.Text;
            adres = textBox2.Text;
            semt = comboBox2.Text;

            if (radioButton1.Checked)
            {
                cnsyt = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                cnsyt = radioButton2.Text;
            }
            if (checkBox1.Checked)
            {
                siparis = checkBox1.Text;
            }
            else if (checkBox2.Checked)
            {
                siparis = checkBox2.Text;
            }
            else if (checkBox3.Checked)
            {
                siparis = checkBox3.Text;
            }
            else if (checkBox4.Checked)
            {
                siparis = checkBox4.Text;
            }




            listBox1.Items.Add("ADI =" + ad + " TELEFON =" + telefon + " ADRES ="+adres+" SEMT = "+semt+ " CİNSİYET ="+cnsyt+" SİPARİŞ = "+siparis);
            MessageBox.Show("SİPARİŞ ALINDI ! ");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            MessageBox.Show("Sipariş Silindi ! ");
        }
    }
    }

