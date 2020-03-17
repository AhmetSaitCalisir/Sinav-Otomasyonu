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
    public partial class Form_Sonuc : Form
    {
        public Form_Sonuc()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-19QN280\SQLEXPRESS;Initial Catalog=SSYS; Integrated Security=True");
        private void Form_Sonuc_Load(object sender, EventArgs e)
        {
            Lbl_Kullanici.Text = Form_Giris.kullanici_Adi;
            bag.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT K.kullanici_Adi,D.ders_Adi,S.Dogru,S.Yanlis,S.Yanlis,S.Bos  FROM (tbl_Sonuc S JOIN tbl_Kullanici K ON S.kullanici_ID=K.kullanici_ID) JOIN tbl_Ders D ON S.ders_ID=D.ders_ID WHERE K.kullanici_ID=" + Form_Giris.kullanici_ID, bag);
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            dataSet.Tables.Add(dataTable);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlCommand.ExecuteNonQuery();
            bag.Close(); 
           
        }

        private void Btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Geri_Click(object sender, EventArgs e)
        {
            Form_Ogrenci form_Ogrenci = new Form_Ogrenci();
            form_Ogrenci.Show();
            this.Hide();
        }
    }
}
