namespace EOkul
{
    partial class ÖğrenciEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.txtSurnameStudent = new System.Windows.Forms.TextBox();
            this.txtNumberStudent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddStudent2 = new System.Windows.Forms.Button();
            this.cbxClassrooms = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğrenci No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Öğrenci Ekle";
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Location = new System.Drawing.Point(272, 40);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.Size = new System.Drawing.Size(100, 20);
            this.txtNameStudent.TabIndex = 1;
            // 
            // txtSurnameStudent
            // 
            this.txtSurnameStudent.Location = new System.Drawing.Point(272, 66);
            this.txtSurnameStudent.Name = "txtSurnameStudent";
            this.txtSurnameStudent.Size = new System.Drawing.Size(100, 20);
            this.txtSurnameStudent.TabIndex = 1;
            // 
            // txtNumberStudent
            // 
            this.txtNumberStudent.Location = new System.Drawing.Point(272, 92);
            this.txtNumberStudent.Name = "txtNumberStudent";
            this.txtNumberStudent.Size = new System.Drawing.Size(100, 20);
            this.txtNumberStudent.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sınıf";
            // 
            // btnAddStudent2
            // 
            this.btnAddStudent2.Location = new System.Drawing.Point(319, 157);
            this.btnAddStudent2.Name = "btnAddStudent2";
            this.btnAddStudent2.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent2.TabIndex = 4;
            this.btnAddStudent2.Text = "Ekle";
            this.btnAddStudent2.UseVisualStyleBackColor = true;
            this.btnAddStudent2.Click += new System.EventHandler(this.btnAddStudent2_Click);
            // 
            // cbxClassrooms
            // 
            this.cbxClassrooms.FormattingEnabled = true;
            this.cbxClassrooms.Location = new System.Drawing.Point(530, 45);
            this.cbxClassrooms.Name = "cbxClassrooms";
            this.cbxClassrooms.Size = new System.Drawing.Size(121, 21);
            this.cbxClassrooms.TabIndex = 5;
            // 
            // ÖğrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxClassrooms);
            this.Controls.Add(this.btnAddStudent2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumberStudent);
            this.Controls.Add(this.txtSurnameStudent);
            this.Controls.Add(this.txtNameStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ÖğrenciEkle";
            this.Text = "ÖğrenciEkle";
            this.Load += new System.EventHandler(this.ÖğrenciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameStudent;
        private System.Windows.Forms.TextBox txtSurnameStudent;
        private System.Windows.Forms.TextBox txtNumberStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddStudent2;
        private System.Windows.Forms.ComboBox cbxClassrooms;
    }
}