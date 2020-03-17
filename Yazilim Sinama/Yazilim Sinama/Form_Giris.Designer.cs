namespace Yazilim_Sinama
{
    partial class Form_Giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Adi = new System.Windows.Forms.TextBox();
            this.Txt_Sifre = new System.Windows.Forms.TextBox();
            this.Btn_Giris = new System.Windows.Forms.Button();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanici Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanici Sifre";
            // 
            // Txt_Adi
            // 
            this.Txt_Adi.Location = new System.Drawing.Point(92, 12);
            this.Txt_Adi.Name = "Txt_Adi";
            this.Txt_Adi.Size = new System.Drawing.Size(100, 20);
            this.Txt_Adi.TabIndex = 2;
            this.Txt_Adi.Text = "Ahmet";
            // 
            // Txt_Sifre
            // 
            this.Txt_Sifre.Location = new System.Drawing.Point(92, 38);
            this.Txt_Sifre.Name = "Txt_Sifre";
            this.Txt_Sifre.PasswordChar = '☪';
            this.Txt_Sifre.Size = new System.Drawing.Size(100, 20);
            this.Txt_Sifre.TabIndex = 3;
            this.Txt_Sifre.Text = "1234";
            // 
            // Btn_Giris
            // 
            this.Btn_Giris.Location = new System.Drawing.Point(19, 64);
            this.Btn_Giris.Name = "Btn_Giris";
            this.Btn_Giris.Size = new System.Drawing.Size(173, 23);
            this.Btn_Giris.TabIndex = 4;
            this.Btn_Giris.Text = "Giriş";
            this.Btn_Giris.UseVisualStyleBackColor = true;
            this.Btn_Giris.Click += new System.EventHandler(this.Btn_Giris_Click);
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.Location = new System.Drawing.Point(19, 93);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(173, 23);
            this.Btn_Cikis.TabIndex = 5;
            this.Btn_Cikis.Text = "Çıkış";
            this.Btn_Cikis.UseVisualStyleBackColor = true;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // Form_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 130);
            this.Controls.Add(this.Btn_Cikis);
            this.Controls.Add(this.Btn_Giris);
            this.Controls.Add(this.Txt_Sifre);
            this.Controls.Add(this.Txt_Adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Adi;
        private System.Windows.Forms.TextBox Txt_Sifre;
        private System.Windows.Forms.Button Btn_Giris;
        private System.Windows.Forms.Button Btn_Cikis;
    }
}

