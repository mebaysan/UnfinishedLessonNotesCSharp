namespace EOkul
{
    partial class ÖğrenciGüncelle
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
            this.cbxClassrooms = new System.Windows.Forms.ComboBox();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberStudentUpdate = new System.Windows.Forms.TextBox();
            this.txtSurnameStudentUpdate = new System.Windows.Forms.TextBox();
            this.txtNameStudentUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxClassrooms
            // 
            this.cbxClassrooms.FormattingEnabled = true;
            this.cbxClassrooms.Location = new System.Drawing.Point(523, 49);
            this.cbxClassrooms.Name = "cbxClassrooms";
            this.cbxClassrooms.Size = new System.Drawing.Size(121, 21);
            this.cbxClassrooms.TabIndex = 15;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(312, 161);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStudent.TabIndex = 14;
            this.btnUpdateStudent.Text = "Güncelle";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sınıf";
            // 
            // txtNumberStudentUpdate
            // 
            this.txtNumberStudentUpdate.Location = new System.Drawing.Point(265, 96);
            this.txtNumberStudentUpdate.Name = "txtNumberStudentUpdate";
            this.txtNumberStudentUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtNumberStudentUpdate.TabIndex = 10;
            // 
            // txtSurnameStudentUpdate
            // 
            this.txtSurnameStudentUpdate.Location = new System.Drawing.Point(265, 70);
            this.txtSurnameStudentUpdate.Name = "txtSurnameStudentUpdate";
            this.txtSurnameStudentUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtSurnameStudentUpdate.TabIndex = 11;
            // 
            // txtNameStudentUpdate
            // 
            this.txtNameStudentUpdate.Location = new System.Drawing.Point(265, 44);
            this.txtNameStudentUpdate.Name = "txtNameStudentUpdate";
            this.txtNameStudentUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtNameStudentUpdate.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Öğrenci Güncelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Öğrenci No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad";
            // 
            // ÖğrenciGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxClassrooms);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumberStudentUpdate);
            this.Controls.Add(this.txtSurnameStudentUpdate);
            this.Controls.Add(this.txtNameStudentUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ÖğrenciGüncelle";
            this.Text = "ÖğrenciGüncelle";
            this.Load += new System.EventHandler(this.ÖğrenciGüncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxClassrooms;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberStudentUpdate;
        private System.Windows.Forms.TextBox txtSurnameStudentUpdate;
        private System.Windows.Forms.TextBox txtNameStudentUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}