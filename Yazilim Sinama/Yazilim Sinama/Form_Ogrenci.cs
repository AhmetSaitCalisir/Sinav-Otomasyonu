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
    public partial class Form_Ogrenci : Form
    {
        public Form_Ogrenci()
        {
            InitializeComponent();
        }
        public static int ders_ID;
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-19QN280\SQLEXPRESS;Initial Catalog=SSYS; Integrated Security=True");
        private void Form_Ogrenci_Load(object sender, EventArgs e)
        {
            Lbl_Kullanici.Text = Form_Giris.kullanici_Adi;
        }

        private void Btn_Git_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tbl_Ders WHERE ders_Adi ='" + Combo_Ders.Text + "'", bag);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                ders_ID = sqlDataReader.GetInt32(0);
                MessageBox.Show(sqlDataReader.GetString(1) + " Dersine yönlendiriliyorsunuz", "Ders Seçimi", MessageBoxButtons.OK);
                Form_Sinav form_Sinav = new Form_Sinav();
                form_Sinav.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ders seçimi hatalı oldu", "HATALI İŞLEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlDataReader.Close();
            sqlCommand.ExecuteNonQuery();
            bag.Close();
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Sonuc_Click(object sender, EventArgs e)
        {
            Form_Sonuc form_Sonuc = new Form_Sonuc();
            form_Sonuc.Show();
            this.Hide();
        }

        private void Btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }
    }
}
