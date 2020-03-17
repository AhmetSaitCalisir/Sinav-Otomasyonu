namespace Yazilim_Sinama
{
    partial class Form_Sonuc
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
            this.Lbl_Kullanici = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.Btn_Geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Kullanici
            // 
            this.Lbl_Kullanici.AutoSize = true;
            this.Lbl_Kullanici.Location = new System.Drawing.Point(13, 13);
            this.Lbl_Kullanici.Name = "Lbl_Kullanici";
            this.Lbl_Kullanici.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Kullanici.TabIndex = 0;
            this.Lbl_Kullanici.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(646, 192);
            this.dataGridView1.TabIndex = 1;
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.Location = new System.Drawing.Point(12, 256);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(646, 23);
            this.Btn_Cikis.TabIndex = 2;
            this.Btn_Cikis.Text = "Çıkış";
            this.Btn_Cikis.UseVisualStyleBackColor = true;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // Btn_Geri
            // 
            this.Btn_Geri.Location = new System.Drawing.Point(12, 227);
            this.Btn_Geri.Name = "Btn_Geri";
            this.Btn_Geri.Size = new System.Drawing.Size(646, 23);
            this.Btn_Geri.TabIndex = 3;
            this.Btn_Geri.Text = "Ana Sayfa";
            this.Btn_Geri.UseVisualStyleBackColor = true;
            this.Btn_Geri.Click += new System.EventHandler(this.Btn_Geri_Click);
            // 
            // Form_Sonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 286);
            this.Controls.Add(this.Btn_Geri);
            this.Controls.Add(this.Btn_Cikis);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lbl_Kullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Sonuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Sonuc";
            this.Load += new System.EventHandler(this.Form_Sonuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Kullanici;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Cikis;
        private System.Windows.Forms.Button Btn_Geri;
    }
}