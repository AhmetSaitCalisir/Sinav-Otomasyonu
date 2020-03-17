namespace Yazilim_Sinama
{
    partial class Form_Ogretmen
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
            this.Cmb_Ders = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Soru = new System.Windows.Forms.RichTextBox();
            this.Txt_Dogru = new System.Windows.Forms.TextBox();
            this.Txt_Yanlis1 = new System.Windows.Forms.TextBox();
            this.Txt_Yanlis2 = new System.Windows.Forms.TextBox();
            this.Txt_Yanlis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_Konu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.Btn_AnaSayfa = new System.Windows.Forms.Button();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.Lbl_Kullanici = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cmb_Ders
            // 
            this.Cmb_Ders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Ders.FormattingEnabled = true;
            this.Cmb_Ders.Location = new System.Drawing.Point(85, 53);
            this.Cmb_Ders.Name = "Cmb_Ders";
            this.Cmb_Ders.Size = new System.Drawing.Size(308, 21);
            this.Cmb_Ders.TabIndex = 0;
            this.Cmb_Ders.SelectedIndexChanged += new System.EventHandler(this.Cmb_Ders_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ders";
            // 
            // Txt_Soru
            // 
            this.Txt_Soru.Enabled = false;
            this.Txt_Soru.Location = new System.Drawing.Point(85, 107);
            this.Txt_Soru.Name = "Txt_Soru";
            this.Txt_Soru.Size = new System.Drawing.Size(308, 96);
            this.Txt_Soru.TabIndex = 2;
            this.Txt_Soru.Text = "";
            // 
            // Txt_Dogru
            // 
            this.Txt_Dogru.Enabled = false;
            this.Txt_Dogru.Location = new System.Drawing.Point(85, 209);
            this.Txt_Dogru.Name = "Txt_Dogru";
            this.Txt_Dogru.Size = new System.Drawing.Size(308, 20);
            this.Txt_Dogru.TabIndex = 3;
            // 
            // Txt_Yanlis1
            // 
            this.Txt_Yanlis1.Enabled = false;
            this.Txt_Yanlis1.Location = new System.Drawing.Point(85, 235);
            this.Txt_Yanlis1.Name = "Txt_Yanlis1";
            this.Txt_Yanlis1.Size = new System.Drawing.Size(308, 20);
            this.Txt_Yanlis1.TabIndex = 4;
            // 
            // Txt_Yanlis2
            // 
            this.Txt_Yanlis2.Enabled = false;
            this.Txt_Yanlis2.Location = new System.Drawing.Point(85, 261);
            this.Txt_Yanlis2.Name = "Txt_Yanlis2";
            this.Txt_Yanlis2.Size = new System.Drawing.Size(308, 20);
            this.Txt_Yanlis2.TabIndex = 5;
            // 
            // Txt_Yanlis
            // 
            this.Txt_Yanlis.Enabled = false;
            this.Txt_Yanlis.Location = new System.Drawing.Point(85, 287);
            this.Txt_Yanlis.Name = "Txt_Yanlis";
            this.Txt_Yanlis.Size = new System.Drawing.Size(308, 20);
            this.Txt_Yanlis.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Konu";
            // 
            // Cmb_Konu
            // 
            this.Cmb_Konu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Konu.Enabled = false;
            this.Cmb_Konu.FormattingEnabled = true;
            this.Cmb_Konu.Location = new System.Drawing.Point(85, 80);
            this.Cmb_Konu.Name = "Cmb_Konu";
            this.Cmb_Konu.Size = new System.Drawing.Size(308, 21);
            this.Cmb_Konu.TabIndex = 8;
            this.Cmb_Konu.SelectedIndexChanged += new System.EventHandler(this.Cmb_Konu_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Doğru Cevap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yanlış Cevap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yanlış Cevap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Yanlış Cevap";
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.Location = new System.Drawing.Point(13, 314);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(380, 23);
            this.Btn_Ekle.TabIndex = 14;
            this.Btn_Ekle.Text = "Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // Btn_AnaSayfa
            // 
            this.Btn_AnaSayfa.Location = new System.Drawing.Point(13, 344);
            this.Btn_AnaSayfa.Name = "Btn_AnaSayfa";
            this.Btn_AnaSayfa.Size = new System.Drawing.Size(380, 23);
            this.Btn_AnaSayfa.TabIndex = 15;
            this.Btn_AnaSayfa.Text = "Ana Sayfa";
            this.Btn_AnaSayfa.UseVisualStyleBackColor = true;
            this.Btn_AnaSayfa.Click += new System.EventHandler(this.Btn_AnaSayfa_Click);
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.Location = new System.Drawing.Point(12, 374);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(381, 23);
            this.Btn_Cikis.TabIndex = 16;
            this.Btn_Cikis.Text = "Çıkış";
            this.Btn_Cikis.UseVisualStyleBackColor = true;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // Lbl_Kullanici
            // 
            this.Lbl_Kullanici.AutoSize = true;
            this.Lbl_Kullanici.Location = new System.Drawing.Point(13, 13);
            this.Lbl_Kullanici.Name = "Lbl_Kullanici";
            this.Lbl_Kullanici.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Kullanici.TabIndex = 17;
            this.Lbl_Kullanici.Text = "label8";
            // 
            // Form_Ogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 412);
            this.Controls.Add(this.Lbl_Kullanici);
            this.Controls.Add(this.Btn_Cikis);
            this.Controls.Add(this.Btn_AnaSayfa);
            this.Controls.Add(this.Btn_Ekle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cmb_Konu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Yanlis);
            this.Controls.Add(this.Txt_Yanlis2);
            this.Controls.Add(this.Txt_Yanlis1);
            this.Controls.Add(this.Txt_Dogru);
            this.Controls.Add(this.Txt_Soru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_Ders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Ogretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Ogretmen";
            this.Load += new System.EventHandler(this.Form_Ogretmen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cmb_Ders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Txt_Soru;
        private System.Windows.Forms.TextBox Txt_Dogru;
        private System.Windows.Forms.TextBox Txt_Yanlis1;
        private System.Windows.Forms.TextBox Txt_Yanlis2;
        private System.Windows.Forms.TextBox Txt_Yanlis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_Konu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.Button Btn_AnaSayfa;
        private System.Windows.Forms.Button Btn_Cikis;
        private System.Windows.Forms.Label Lbl_Kullanici;
    }
}