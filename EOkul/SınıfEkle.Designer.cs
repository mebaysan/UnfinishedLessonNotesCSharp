namespace EOkul
{
    partial class SınıfEkle
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
            this.txtClassroomAdd = new System.Windows.Forms.TextBox();
            this.btnClassroomAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf Adı";
            // 
            // txtClassroomAdd
            // 
            this.txtClassroomAdd.Location = new System.Drawing.Point(197, 48);
            this.txtClassroomAdd.Name = "txtClassroomAdd";
            this.txtClassroomAdd.Size = new System.Drawing.Size(100, 20);
            this.txtClassroomAdd.TabIndex = 1;
            // 
            // btnClassroomAdd
            // 
            this.btnClassroomAdd.Location = new System.Drawing.Point(179, 120);
            this.btnClassroomAdd.Name = "btnClassroomAdd";
            this.btnClassroomAdd.Size = new System.Drawing.Size(75, 23);
            this.btnClassroomAdd.TabIndex = 2;
            this.btnClassroomAdd.Text = "Sınıf Ekle";
            this.btnClassroomAdd.UseVisualStyleBackColor = true;
            this.btnClassroomAdd.Click += new System.EventHandler(this.btnClassroomAdd_Click);
            // 
            // SınıfEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 203);
            this.Controls.Add(this.btnClassroomAdd);
            this.Controls.Add(this.txtClassroomAdd);
            this.Controls.Add(this.label1);
            this.Name = "SınıfEkle";
            this.Text = "SınıfEkle";
            this.Load += new System.EventHandler(this.SınıfEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassroomAdd;
        private System.Windows.Forms.Button btnClassroomAdd;
    }
}