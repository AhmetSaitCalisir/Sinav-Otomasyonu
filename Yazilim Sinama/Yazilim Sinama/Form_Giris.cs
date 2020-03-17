using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yazilim_Sinama
{
    
    public partial class Form_Giris : Form
    {
        public static string kullanici_Adi;
        public static int kullanici_ID;
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-19QN280\SQLEXPRESS;Initial Catalog=SSYS; Integrated Security=True");
        public Form_Giris()
        {
            InitializeComponent();
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tbl_Kullanici WHERE kullanici_Adi ='" + Txt_Adi.Text + "' AND kullanici_Sifre ='" + Txt_Sifre.Text+"'",bag);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                kullanici_ID = sqlDataReader.GetInt32(0);
                kullanici_Adi = sqlDataReader.GetString(1);
                MessageBox.Show("Hoşgeldin "+kullanici_Adi,"HOŞGELDİNİZ",MessageBoxButtons.OK);
                int tur = sqlDataReader.GetInt32(3);
                if (tur == 1)//Öğrenci için giriş
                {
                    Form_Ogrenci form_Ogrenci = new Form_Ogrenci();
                    form_Ogrenci.Show();
                    this.Hide();
                }
                else if (tur == 2)
                {
                    Form_Ogretmen form_Ogretmen = new Form_Ogretmen();
                    form_Ogretmen.Show();
                    this.Hide();
                }
                else if (tur == 3)
                {
                    Form_Admin form_Admin = new Form_Admin();
                    form_Admin.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış", "HATLI GİRİŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlDataReader.Close();
            sqlCommand.ExecuteNonQuery();
            bag.Close();

        }
    }
}
