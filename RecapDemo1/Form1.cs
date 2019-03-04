using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Button[,] buttons = new Button[8, 8];  //  Button classından button adında bir değişken oluşturduk. Burda bir dizi oluşturduk ve 8e 8lik bir buton dizisi.
            int top = 0;    // bir üst değişkeni
            int left = 0;  // burda bir sol değişkeni
            for (int i = 0; i < buttons.GetUpperBound(0); i++) // getupperbound -> ilk boyutun alabileceği max değer Satır değeri için 8 sütun ayarladık
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++) // Sütun değerlerini belirledik
                {
                    buttons[i, j] = new Button(); // yeni bir buton oluşturduk
                    buttons[i, j].Width = 50; // buttons objesinin özellikleri belirledik
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i + j) % 2 == 0)  // burda kendimizce bir algoritma oluşturduk. i ve j nin toplamının 2 ye bölümü 0 ise
                    {
                        buttons[i, j].BackColor = Color.Black; // arka planı siyah yap dedik
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White; // değilse arka plan beyaz olsun dedik
                    }

                    this.Controls.Add(buttons[i, j]); // this.Controls.Add -> butonu ekrana koy
                }
                top += 50; // ikinci satıra geçince yükseliği 50 artır dedik
                left = 0;   // ikinci satıra geçince sol değerini tekrar 0 yap dedik. Sebebi ise tekrar soldan buton dizmeye başlasın ve 8x8 bir görüntü olsun.
            }

        }
    }
}
