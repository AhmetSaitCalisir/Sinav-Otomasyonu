namespace Yazilim_Sinama
{
    partial class Form_Ogrenci
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
            this.Combo_Ders = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Git = new System.Windows.Forms.Button();
            this.Btn_Sonuc = new System.Windows.Forms.Button();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.Btn_AnaSayfa = new System.Windows.Forms.Button();
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
            // Combo_Ders
            // 
            this.Combo_Ders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Ders.FormattingEnabled = true;
            this.Combo_Ders.Items.AddRange(new object[] {
            "Matematik",
            "Fizik"});
            this.Combo_Ders.Location = new System.Drawing.Point(68, 42);
            this.Combo_Ders.Name = "Combo_Ders";
            this.Combo_Ders.Size = new System.Drawing.Size(121, 21);
            this.Combo_Ders.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ders Seç";
            // 
            // Btn_Git
            // 
            this.Btn_Git.Location = new System.Drawing.Point(16, 69);
            this.Btn_Git.Name = "Btn_Git";
            this.Btn_Git.Size = new System.Drawing.Size(173, 23);
            this.Btn_Git.TabIndex = 3;
            this.Btn_Git.Text = "Derse Git";
            this.Btn_Git.UseVisualStyleBackColor = true;
            this.Btn_Git.Click += new System.EventHandler(this.Btn_Git_Click);
            // 
            // Btn_Sonuc
            // 
            this.Btn_Sonuc.Location = new System.Drawing.Point(16, 99);
            this.Btn_Sonuc.Name = "Btn_Sonuc";
            this.Btn_Sonuc.Size = new System.Drawing.Size(173, 23);
            this.Btn_Sonuc.TabIndex = 4;
            this.Btn_Sonuc.Text = "Sonuçları Göster";
            this.Btn_Sonuc.UseVisualStyleBackColor = true;
            this.Btn_Sonuc.Click += new System.EventHandler(this.Btn_Sonuc_Click);
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.Location = new System.Drawing.Point(16, 157);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(173, 23);
            this.Btn_Cikis.TabIndex = 5;
            this.Btn_Cikis.Text = "Çıkış";
            this.Btn_Cikis.UseVisualStyleBackColor = true;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // Btn_AnaSayfa
            // 
            this.Btn_AnaSayfa.Location = new System.Drawing.Point(16, 128);
            this.Btn_AnaSayfa.Name = "Btn_AnaSayfa";
            this.Btn_AnaSayfa.Size = new System.Drawing.Size(173, 23);
            this.Btn_AnaSayfa.TabIndex = 6;
            this.Btn_AnaSayfa.Text = "Ana Sayfa";
            this.Btn_AnaSayfa.UseVisualStyleBackColor = true;
            this.Btn_AnaSayfa.Click += new System.EventHandler(this.Btn_AnaSayfa_Click);
            // 
            // Form_Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 190);
            this.Controls.Add(this.Btn_AnaSayfa);
            this.Controls.Add(this.Btn_Cikis);
            this.Controls.Add(this.Btn_Sonuc);
            this.Controls.Add(this.Btn_Git);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Combo_Ders);
            this.Controls.Add(this.Lbl_Kullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Ogrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Ogrenci";
            this.Load += new System.EventHandler(this.Form_Ogrenci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Kullanici;
        private System.Windows.Forms.ComboBox Combo_Ders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Git;
        private System.Windows.Forms.Button Btn_Sonuc;
        private System.Windows.Forms.Button Btn_Cikis;
        private System.Windows.Forms.Button Btn_AnaSayfa;
    }
}