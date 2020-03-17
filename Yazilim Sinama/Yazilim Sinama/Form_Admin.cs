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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-19QN280\SQLEXPRESS;Initial Catalog=SSYS; Integrated Security=True");
        int ders_ID = -1;
        int konu_ID = -1;
        int soru_ID = -1;
        private void Form_Admin_Load(object sender, EventArgs e)
        {
            Lbl_Kullanici.Text = Form_Giris.kullanici_Adi;
            Yukle();
        }
        private void Yukle()
        {
            bag.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From tbl_SoruOnaysiz",bag);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                Txt_Soru.Text = sqlDataReader.GetString(2);
                Txt_Cevap.Text = sqlDataReader.GetString(3);
                Txt_Yanlis.Text = sqlDataReader.GetString(4);
                Txt_Yanlis1.Text = sqlDataReader.GetString(5);
                Txt_Yanlis2.Text = sqlDataReader.GetString(6);
                ders_ID = sqlDataReader.GetInt32(1);
                konu_ID = sqlDataReader.GetInt32(7);
                soru_ID = sqlDataReader.GetInt32(0);
            }
            else
            {
                Txt_Soru.Text = "Onaylanacak Soru Yok";
                Txt_Cevap.Text = "Onaylanacak Soru Yok";
                Txt_Yanlis.Text = "Onaylanacak Soru Yok";
                Txt_Yanlis1.Text = "Onaylanacak Soru Yok";
                Txt_Yanlis2.Text = "Onaylanacak Soru Yok";
                Btn_Onayla.Enabled = false;
                Btn_Reddet.Enabled = false;
                MessageBox.Show("Yeni Soru Yok");
            }
            sqlDataReader.Close();
            sqlCommand.ExecuteNonQuery();
            bag.Close();
        }

        private void Btn_Onayla_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into tbl_Soru(ders_ID,soru_Soru,soru_CevapD,soru_Yanlis1,soru_Yanlis2,soru_Yanlis3,soru_KonuID) Select ders_ID,soru_Soru,soru_CevapD,soru_Yanlis1,soru_Yanlis2,soru_Yanlis3,soru_KonuID  From tbl_SoruOnaysiz O Where O.soru_ID="+soru_ID.ToString(), bag);
            sqlCommand.ExecuteNonQuery();
            SqlCommand sqlCommand1 = new SqlCommand("Delete From tbl_SoruOnaysiz Where soru_ID="+soru_ID.ToString(), bag);
            sqlCommand1.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Soru Onaylandı");
            Yukle();
        }

        private void Btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Reddet_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand sqlCommand1 = new SqlCommand("Delete From tbl_SoruOnaysiz Where soru_ID=" + soru_ID.ToString(), bag);
            sqlCommand1.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Soru Reddedildi");
            Yukle();
        }

        private void Btn_Yenile_Click(object sender, EventArgs e)
        {
            Yukle();
        }
    }
}
