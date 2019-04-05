namespace TelefonRehberi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstwPersons = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblGsm = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtGsm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstwPersons
            // 
            this.lstwPersons.Location = new System.Drawing.Point(348, 60);
            this.lstwPersons.Name = "lstwPersons";
            this.lstwPersons.Size = new System.Drawing.Size(239, 117);
            this.lstwPersons.TabIndex = 0;
            this.lstwPersons.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(188, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(74, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(20, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ad";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(74, 106);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(37, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Soyad";
            this.lblSurname.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGsm
            // 
            this.lblGsm.AutoSize = true;
            this.lblGsm.Location = new System.Drawing.Point(74, 132);
            this.lblGsm.Name = "lblGsm";
            this.lblGsm.Size = new System.Drawing.Size(31, 13);
            this.lblGsm.TabIndex = 4;
            this.lblGsm.Text = "GSM";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(179, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(179, 106);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 6;
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(179, 132);
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(100, 20);
            this.txtGsm.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 333);
            this.Controls.Add(this.txtGsm);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGsm);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstwPersons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstwPersons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblGsm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtGsm;
    }
}

