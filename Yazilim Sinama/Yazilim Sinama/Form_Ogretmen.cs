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
    public partial class Form_Ogretmen : Form
    {
        public Form_Ogretmen()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-19QN280\SQLEXPRESS;Initial Catalog=SSYS; Integrated Security=True");
        private void Form_Ogretmen_Load(object sender, EventArgs e)
        {

            Lbl_Kullanici.Text = Form_Giris.kullanici_Adi;
            bag.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * From tbl_Ders", bag);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Cmb_Ders.Items.Add(sqlDataReader.GetString(1));
            }
            sqlDataReader.Close();
            sqlCommand.ExecuteNonQuery();
            bag.Close();
        }

        private void Btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            Form_Giris form_Giris = new Form_Giris();
            form_Giris.Show();
            this.Hide();
        }
        int dersID = -1;
        private void KonuGoster()
        {
            Cmb_Konu.Items.Clear();
            bag.Open();
            SqlCommand sqlCommand = new SqlCommand("Select K.konu_Adi,D.ders_ID From tbl_Ders D JOIN tbl_Konu K ON D.ders_ID = K.ders_ID Where D.ders_Adi='" + Cmb_Ders.Text + "'", bag);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Cmb_Konu.Items.Add(sqlDataReader.GetString(0));
                dersID = sqlDataReader.GetInt32(1);
            }
            sqlDataReader.Close();
            sqlCommand.ExecuteNonQuery();
            bag.Close();
            Cmb_Konu.Enabled = true;
        }
        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cmb_Ders_SelectedIndexChanged(object sender, EventArgs e)
        {
            KonuGoster();
        }

        private void Cmb_Konu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_Dogru.Enabled = true;
            Txt_Soru.Enabled = true;
            Txt_Yanlis.Enabled = true;
            Txt_Yanlis1.Enabled = true;
            Txt_Yanlis2.Enabled = true;

        }
        private void Temizle()
        {
            Txt_Dogru.Text = "";
            Txt_Soru.Text = "";
            Txt_Yanlis.Text = "";
            Txt_Yanlis1.Text = "";
            Txt_Yanlis2.Text = "";
        }
        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand sqlCommand = new SqlCommand("Select konu_ID From tbl_Konu Where konu_Adi='" + Cmb_Konu.Text + "'", bag);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            int konuID=-1;
            if (sqlDataReader.Read())
            {
                konuID = sqlDataReader.GetInt32(0);
            }
            
            sqlDataReader.Close();
            sqlCommand.ExecuteNonQuery();
            SqlCommand sqlCommandd = new SqlCommand("insert tbl_SoruOnaysiz(soru_Soru,soru_CevapD,soru_Yanlis1,soru_Yanlis2,soru_Yanlis3,soru_KonuID,ders_ID) values ('" + Txt_Soru.Text + "','" + Txt_Dogru.Text + "','" + Txt_Yanlis.Text + "','" + Txt_Yanlis1.Text + "','" + Txt_Yanlis2.Text + "',"+konuID.ToString()+","+dersID.ToString()+")", bag);
            sqlCommandd.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Soru Başarıyla Eklendi");
            Temizle();
        }
    }
}
