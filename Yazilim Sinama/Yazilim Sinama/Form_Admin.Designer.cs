namespace Yazilim_Sinama
{
    partial class Form_Admin
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
            this.Txt_Soru = new System.Windows.Forms.RichTextBox();
            this.Txt_Cevap = new System.Windows.Forms.TextBox();
            this.Txt_Yanlis = new System.Windows.Forms.TextBox();
            this.Txt_Yanlis1 = new System.Windows.Forms.TextBox();
            this.Txt_Yanlis2 = new System.Windows.Forms.TextBox();
            this.Btn_Onayla = new System.Windows.Forms.Button();
            this.Btn_Reddet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_AnaSayfa = new System.Windows.Forms.Button();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.Btn_Yenile = new System.Windows.Forms.Button();
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
            // Txt_Soru
            // 
            this.Txt_Soru.Enabled = false;
            this.Txt_Soru.Location = new System.Drawing.Point(97, 33);
            this.Txt_Soru.Name = "Txt_Soru";
            this.Txt_Soru.Size = new System.Drawing.Size(329, 96);
            this.Txt_Soru.TabIndex = 1;
            this.Txt_Soru.Text = "";
            // 
            // Txt_Cevap
            // 
            this.Txt_Cevap.Enabled = false;
            this.Txt_Cevap.Location = new System.Drawing.Point(97, 136);
            this.Txt_Cevap.Name = "Txt_Cevap";
            this.Txt_Cevap.Size = new System.Drawing.Size(329, 20);
            this.Txt_Cevap.TabIndex = 2;
            // 
            // Txt_Yanlis
            // 
            this.Txt_Yanlis.Enabled = false;
            this.Txt_Yanlis.Location = new System.Drawing.Point(97, 163);
            this.Txt_Yanlis.Name = "Txt_Yanlis";
            this.Txt_Yanlis.Size = new System.Drawing.Size(329, 20);
            this.Txt_Yanlis.TabIndex = 3;
            // 
            // Txt_Yanlis1
            // 
            this.Txt_Yanlis1.Enabled = false;
            this.Txt_Yanlis1.Location = new System.Drawing.Point(97, 190);
            this.Txt_Yanlis1.Name = "Txt_Yanlis1";
            this.Txt_Yanlis1.Size = new System.Drawing.Size(329, 20);
            this.Txt_Yanlis1.TabIndex = 4;
            // 
            // Txt_Yanlis2
            // 
            this.Txt_Yanlis2.Enabled = false;
            this.Txt_Yanlis2.Location = new System.Drawing.Point(97, 217);
            this.Txt_Yanlis2.Name = "Txt_Yanlis2";
            this.Txt_Yanlis2.Size = new System.Drawing.Size(329, 20);
            this.Txt_Yanlis2.TabIndex = 5;
            // 
            // Btn_Onayla
            // 
            this.Btn_Onayla.Location = new System.Drawing.Point(97, 243);
            this.Btn_Onayla.Name = "Btn_Onayla";
            this.Btn_Onayla.Size = new System.Drawing.Size(160, 23);
            this.Btn_Onayla.TabIndex = 6;
            this.Btn_Onayla.Text = "Onayla";
            this.Btn_Onayla.UseVisualStyleBackColor = true;
            this.Btn_Onayla.Click += new System.EventHandler(this.Btn_Onayla_Click);
            // 
            // Btn_Reddet
            // 
            this.Btn_Reddet.Location = new System.Drawing.Point(263, 243);
            this.Btn_Reddet.Name = "Btn_Reddet";
            this.Btn_Reddet.Size = new System.Drawing.Size(163, 23);
            this.Btn_Reddet.TabIndex = 7;
            this.Btn_Reddet.Text = "Reddet";
            this.Btn_Reddet.UseVisualStyleBackColor = true;
            this.Btn_Reddet.Click += new System.EventHandler(this.Btn_Reddet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Soru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Doğru Cevap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yanlis Cevap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yanlis Cevap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yanlis Cevap";
            // 
            // Btn_AnaSayfa
            // 
            this.Btn_AnaSayfa.Location = new System.Drawing.Point(97, 273);
            this.Btn_AnaSayfa.Name = "Btn_AnaSayfa";
            this.Btn_AnaSayfa.Size = new System.Drawing.Size(329, 23);
            this.Btn_AnaSayfa.TabIndex = 13;
            this.Btn_AnaSayfa.Text = "Ana Sayfa";
            this.Btn_AnaSayfa.UseVisualStyleBackColor = true;
            this.Btn_AnaSayfa.Click += new System.EventHandler(this.Btn_AnaSayfa_Click);
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.Location = new System.Drawing.Point(97, 303);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(329, 23);
            this.Btn_Cikis.TabIndex = 14;
            this.Btn_Cikis.Text = "Çıkış";
            this.Btn_Cikis.UseVisualStyleBackColor = true;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // Btn_Yenile
            // 
            this.Btn_Yenile.Location = new System.Drawing.Point(16, 243);
            this.Btn_Yenile.Name = "Btn_Yenile";
            this.Btn_Yenile.Size = new System.Drawing.Size(75, 83);
            this.Btn_Yenile.TabIndex = 15;
            this.Btn_Yenile.Text = "Yenile";
            this.Btn_Yenile.UseVisualStyleBackColor = true;
            this.Btn_Yenile.Click += new System.EventHandler(this.Btn_Yenile_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 352);
            this.Controls.Add(this.Btn_Yenile);
            this.Controls.Add(this.Btn_Cikis);
            this.Controls.Add(this.Btn_AnaSayfa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Reddet);
            this.Controls.Add(this.Btn_Onayla);
            this.Controls.Add(this.Txt_Yanlis2);
            this.Controls.Add(this.Txt_Yanlis1);
            this.Controls.Add(this.Txt_Yanlis);
            this.Controls.Add(this.Txt_Cevap);
            this.Controls.Add(this.Txt_Soru);
            this.Controls.Add(this.Lbl_Kullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Admin";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Kullanici;
        private System.Windows.Forms.RichTextBox Txt_Soru;
        private System.Windows.Forms.TextBox Txt_Cevap;
        private System.Windows.Forms.TextBox Txt_Yanlis;
        private System.Windows.Forms.TextBox Txt_Yanlis1;
        private System.Windows.Forms.TextBox Txt_Yanlis2;
        private System.Windows.Forms.Button Btn_Onayla;
        private System.Windows.Forms.Button Btn_Reddet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_AnaSayfa;
        private System.Windows.Forms.Button Btn_Cikis;
        private System.Windows.Forms.Button Btn_Yenile;
    }
}