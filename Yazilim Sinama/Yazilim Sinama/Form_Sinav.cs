using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazilim_Sinama
{
    public partial class Form_Sinav : Form
    {
        List<Soru> Sorular = new List<Soru>();
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-19QN280\SQLEXPRESS;Initial Catalog=SSYS; Integrated Security=True");
        List<string> Cevaplar = new List<string>();
        int SoruID = 0; 
        List<RadioButton> Siklar = new List<RadioButton>();
        
        public Form_Sinav()
        {
            InitializeComponent();
             
        }
        

        private void Form_Sinav_Load(object sender, EventArgs e)
        {
            Siklar.Add(Cevap1);
            Siklar.Add(Cevap2);
            Siklar.Add(Cevap3);
            Siklar.Add(Cevap4);
            Sorular.Clear();
            Lbl_Kullanici.Text = Form_Giris.kullanici_Adi;
            
            for (int i = 1; i <= 8; i++) 
            {
                bag.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT TOP 5 * FROM tbl_Soru WHERE soru_KonuID="+i.ToString()+" AND ders_ID='" + Form_Ogrenci.ders_ID + "' ORDER BY NewID()",bag);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Sorular.Add(new Soru
                    {
                        So = sqlDataReader.GetString(2),
                        cd = sqlDataReader.GetString(3),
                        y1 = sqlDataReader.GetString(4),
                        y2 = sqlDataReader.GetString(5),
                        y3 = sqlDataReader.GetString(6)
                    }
                    );
                }
                sqlDataReader.Close();
                sqlCommand.ExecuteNonQuery();
                bag.Close();
                for (int b = 0; b<=Sorular.Count;b++)
                {
                    Cevaplar.Add("Boş");
                }
                
            }
            Goster(Sorular[SoruID]);
        }

        private void Temizle()
        {
            Cevap1.Checked = false;
            Cevap2.Checked = false;
            Cevap3.Checked = false;
            Cevap4.Checked = false;
            CevapGoster();
        }
        private void Goster(Soru i)
        {
            SoruTextBox.Text = "Soru "+(SoruID+1).ToString()+" \n"+i.So;
            Random random = new Random();
            int r = random.Next(3);
            RadioButton x = Siklar[r];
            Siklar[r].Text = i.cd;
            Siklar.RemoveAt(r);
            Siklar[0].Text = i.y1;
            Siklar[1].Text = i.y2;
            Siklar[2].Text = i.y3;
            Siklar.Add(x);
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CevapGoster()
        {
            foreach (RadioButton x in Siklar)
            {
                if (x.Text==Cevaplar[SoruID])
                {
                    x.Checked = true;
                }
            }

        }

        private void Btn_Cevapla_Click(object sender, EventArgs e)
        {
            foreach (RadioButton x in Siklar)
            {
                if (x.Checked)
                {
                    Cevaplar[SoruID] = x.Text;
                }
            }
            Btn_Sonraki_Click(sender,e);
        }

        private void Btn_Onceki_Click(object sender, EventArgs e)
        {
            try
            {
                SoruID--;
                Goster(Sorular[SoruID]);
            }
            catch
            {
                SoruID = Sorular.Count-1;
                Goster(Sorular[SoruID]);
            }
            Temizle();
        }

        private void Btn_Sonraki_Click(object sender, EventArgs e)
        {
            try 
            {
                SoruID++;
                Goster(Sorular[SoruID]);
            }
            catch
            {
                SoruID = 0;
                Goster(Sorular[SoruID]);
            }
            Temizle();
        }

        private void Btn_Bitir_Click(object sender, EventArgs e)
        {
            Sayac.Enabled = false;
            int Dogru = 0;
            int Bos = 0;
            int Yanlis = 0;
            for (int i = 0; i < Sorular.Count; i++)
            {
                if (Cevaplar[i] == "Boş")
                {
                    Bos++;
                }
                else if (Cevaplar[i] == Sorular[i].cd)
                {
                    Dogru++;
                }
                else if (Cevaplar[i] != Sorular[i].cd)
                {
                    Yanlis++;
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }
            MessageBox.Show("Sınavı Başarıyla Bitirdiniz \nDoğru Sayınız = " + Dogru.ToString() + "\nYanlış Sayınız = " + Yanlis.ToString() + "\nBoş Sayınız = " + Bos.ToString()+"\nKalan Süre "+Lbl_GeriSayim.Text,"TEBRİKLER",MessageBoxButtons.OK,MessageBoxIcon.Information);

            bag.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tbl_Sonuc WHERE kullanici_ID ="+Form_Giris.kullanici_ID+" AND ders_ID="+Form_Ogrenci.ders_ID, bag);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            
            if (sqlDataReader.Read())
            {
                Dogru += sqlDataReader.GetInt32(2);
                Yanlis += sqlDataReader.GetInt32(3);
                Bos += sqlDataReader.GetInt32(4);
                sqlDataReader.Close();
                SqlCommand sql = new SqlCommand("update tbl_Sonuc set Dogru=" + Dogru.ToString() + ",Yanlis=" + Yanlis.ToString() + ",Bos=" + Bos.ToString(),bag);
                sql.ExecuteNonQuery();
            }
            else
            {
                sqlDataReader.Close();
                SqlCommand sql = new SqlCommand("insert into tbl_Sonuc(kullanici_ID,ders_ID,Dogru,Yanlis,Bos) values (" + Form_Giris.kullanici_ID.ToString() + "," + Form_Ogrenci.ders_ID.ToString() + "," + Dogru.ToString() + "," + Yanlis.ToString()+","+Bos.ToString()+")",bag);
                sql.ExecuteNonQuery();
            }
            sqlCommand.ExecuteNonQuery();
            bag.Close();
            Form_Ogrenci form_Ogrenci = new Form_Ogrenci();
            form_Ogrenci.Show();
            this.Hide();
        }

        private void Btn_Bos_Click(object sender, EventArgs e)
        {
            Cevaplar[SoruID] = "Boş";
            Btn_Sonraki_Click(sender, e);
        }
        int Sayim = 600;
        private void Sayac_Tick(object sender, EventArgs e)
        {
            Sayim--;
            TimeSpan Sonuc = TimeSpan.FromSeconds(Sayim);
            Lbl_GeriSayim.Text = Sonuc.ToString("mm':'ss");
            if (Sayim <= 0)
            {
                Btn_Bitir_Click(sender, e);
                Sayac.Enabled = false;
            }
        }
    }
}
