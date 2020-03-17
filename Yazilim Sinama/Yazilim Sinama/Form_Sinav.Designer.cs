namespace Yazilim_Sinama
{
    partial class Form_Sinav
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
            this.components = new System.ComponentModel.Container();
            this.Lbl_Kullanici = new System.Windows.Forms.Label();
            this.SoruTextBox = new System.Windows.Forms.RichTextBox();
            this.Cevap1 = new System.Windows.Forms.RadioButton();
            this.Cevap2 = new System.Windows.Forms.RadioButton();
            this.Cevap3 = new System.Windows.Forms.RadioButton();
            this.Cevap4 = new System.Windows.Forms.RadioButton();
            this.Btn_Cevapla = new System.Windows.Forms.Button();
            this.Btn_Bitir = new System.Windows.Forms.Button();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.Btn_Onceki = new System.Windows.Forms.Button();
            this.Btn_Sonraki = new System.Windows.Forms.Button();
            this.Btn_Bos = new System.Windows.Forms.Button();
            this.Lbl_GeriSayim = new System.Windows.Forms.Label();
            this.Sayac = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Lbl_Kullanici
            // 
            this.Lbl_Kullanici.AutoSize = true;
            this.Lbl_Kullanici.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Kullanici.Name = "Lbl_Kullanici";
            this.Lbl_Kullanici.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Kullanici.TabIndex = 0;
            this.Lbl_Kullanici.Text = "label1";
            // 
            // SoruTextBox
            // 
            this.SoruTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SoruTextBox.Enabled = false;
            this.SoruTextBox.Location = new System.Drawing.Point(15, 25);
            this.SoruTextBox.Name = "SoruTextBox";
            this.SoruTextBox.Size = new System.Drawing.Size(365, 96);
            this.SoruTextBox.TabIndex = 1;
            this.SoruTextBox.Text = "";
            // 
            // Cevap1
            // 
            this.Cevap1.AutoSize = true;
            this.Cevap1.Location = new System.Drawing.Point(15, 127);
            this.Cevap1.Name = "Cevap1";
            this.Cevap1.Size = new System.Drawing.Size(85, 17);
            this.Cevap1.TabIndex = 2;
            this.Cevap1.Text = "radioButton1";
            this.Cevap1.UseVisualStyleBackColor = true;
            // 
            // Cevap2
            // 
            this.Cevap2.AutoSize = true;
            this.Cevap2.Location = new System.Drawing.Point(15, 150);
            this.Cevap2.Name = "Cevap2";
            this.Cevap2.Size = new System.Drawing.Size(85, 17);
            this.Cevap2.TabIndex = 3;
            this.Cevap2.Text = "radioButton2";
            this.Cevap2.UseVisualStyleBackColor = true;
            // 
            // Cevap3
            // 
            this.Cevap3.AutoSize = true;
            this.Cevap3.Location = new System.Drawing.Point(15, 173);
            this.Cevap3.Name = "Cevap3";
            this.Cevap3.Size = new System.Drawing.Size(85, 17);
            this.Cevap3.TabIndex = 4;
            this.Cevap3.Text = "radioButton3";
            this.Cevap3.UseVisualStyleBackColor = true;
            // 
            // Cevap4
            // 
            this.Cevap4.AutoSize = true;
            this.Cevap4.Location = new System.Drawing.Point(15, 196);
            this.Cevap4.Name = "Cevap4";
            this.Cevap4.Size = new System.Drawing.Size(85, 17);
            this.Cevap4.TabIndex = 5;
            this.Cevap4.Text = "radioButton4";
            this.Cevap4.UseVisualStyleBackColor = true;
            // 
            // Btn_Cevapla
            // 
            this.Btn_Cevapla.Location = new System.Drawing.Point(15, 220);
            this.Btn_Cevapla.Name = "Btn_Cevapla";
            this.Btn_Cevapla.Size = new System.Drawing.Size(56, 23);
            this.Btn_Cevapla.TabIndex = 6;
            this.Btn_Cevapla.Text = "Cevapla";
            this.Btn_Cevapla.UseVisualStyleBackColor = true;
            this.Btn_Cevapla.Click += new System.EventHandler(this.Btn_Cevapla_Click);
            // 
            // Btn_Bitir
            // 
            this.Btn_Bitir.Location = new System.Drawing.Point(329, 220);
            this.Btn_Bitir.Name = "Btn_Bitir";
            this.Btn_Bitir.Size = new System.Drawing.Size(51, 23);
            this.Btn_Bitir.TabIndex = 7;
            this.Btn_Bitir.Text = "Bitir";
            this.Btn_Bitir.UseVisualStyleBackColor = true;
            this.Btn_Bitir.Click += new System.EventHandler(this.Btn_Bitir_Click);
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.Location = new System.Drawing.Point(15, 249);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(365, 23);
            this.Btn_Cikis.TabIndex = 8;
            this.Btn_Cikis.Text = "Çıkış";
            this.Btn_Cikis.UseVisualStyleBackColor = true;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // Btn_Onceki
            // 
            this.Btn_Onceki.Location = new System.Drawing.Point(77, 220);
            this.Btn_Onceki.Name = "Btn_Onceki";
            this.Btn_Onceki.Size = new System.Drawing.Size(75, 23);
            this.Btn_Onceki.TabIndex = 9;
            this.Btn_Onceki.Text = "Önceki Soru";
            this.Btn_Onceki.UseVisualStyleBackColor = true;
            this.Btn_Onceki.Click += new System.EventHandler(this.Btn_Onceki_Click);
            // 
            // Btn_Sonraki
            // 
            this.Btn_Sonraki.Location = new System.Drawing.Point(158, 220);
            this.Btn_Sonraki.Name = "Btn_Sonraki";
            this.Btn_Sonraki.Size = new System.Drawing.Size(85, 23);
            this.Btn_Sonraki.TabIndex = 10;
            this.Btn_Sonraki.Text = "Sonraki Soru";
            this.Btn_Sonraki.UseVisualStyleBackColor = true;
            this.Btn_Sonraki.Click += new System.EventHandler(this.Btn_Sonraki_Click);
            // 
            // Btn_Bos
            // 
            this.Btn_Bos.Location = new System.Drawing.Point(249, 220);
            this.Btn_Bos.Name = "Btn_Bos";
            this.Btn_Bos.Size = new System.Drawing.Size(74, 23);
            this.Btn_Bos.TabIndex = 11;
            this.Btn_Bos.Text = "Boş Bırak";
            this.Btn_Bos.UseVisualStyleBackColor = true;
            this.Btn_Bos.Click += new System.EventHandler(this.Btn_Bos_Click);
            // 
            // Lbl_GeriSayim
            // 
            this.Lbl_GeriSayim.AutoSize = true;
            this.Lbl_GeriSayim.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_GeriSayim.Location = new System.Drawing.Point(268, 128);
            this.Lbl_GeriSayim.Name = "Lbl_GeriSayim";
            this.Lbl_GeriSayim.Size = new System.Drawing.Size(112, 42);
            this.Lbl_GeriSayim.TabIndex = 12;
            this.Lbl_GeriSayim.Text = "00:00";
            // 
            // Sayac
            // 
            this.Sayac.Enabled = true;
            this.Sayac.Interval = 1000;
            this.Sayac.Tick += new System.EventHandler(this.Sayac_Tick);
            // 
            // Form_Sinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 286);
            this.Controls.Add(this.Lbl_GeriSayim);
            this.Controls.Add(this.Btn_Bos);
            this.Controls.Add(this.Btn_Sonraki);
            this.Controls.Add(this.Btn_Onceki);
            this.Controls.Add(this.Btn_Cikis);
            this.Controls.Add(this.Btn_Bitir);
            this.Controls.Add(this.Btn_Cevapla);
            this.Controls.Add(this.Cevap4);
            this.Controls.Add(this.Cevap3);
            this.Controls.Add(this.Cevap2);
            this.Controls.Add(this.Cevap1);
            this.Controls.Add(this.SoruTextBox);
            this.Controls.Add(this.Lbl_Kullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Sinav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Sinav";
            this.Load += new System.EventHandler(this.Form_Sinav_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Kullanici;
        private System.Windows.Forms.RichTextBox SoruTextBox;
        private System.Windows.Forms.RadioButton Cevap1;
        private System.Windows.Forms.RadioButton Cevap2;
        private System.Windows.Forms.RadioButton Cevap3;
        private System.Windows.Forms.RadioButton Cevap4;
        private System.Windows.Forms.Button Btn_Cevapla;
        private System.Windows.Forms.Button Btn_Bitir;
        private System.Windows.Forms.Button Btn_Cikis;
        private System.Windows.Forms.Button Btn_Onceki;
        private System.Windows.Forms.Button Btn_Sonraki;
        private System.Windows.Forms.Button Btn_Bos;
        private System.Windows.Forms.Label Lbl_GeriSayim;
        private System.Windows.Forms.Timer Sayac;
    }
}