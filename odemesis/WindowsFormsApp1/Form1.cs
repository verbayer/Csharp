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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-P0IRDMT;Initial Catalog=uni-kayit;Integrated Security=True");
        int ucret = 0, odeme = 0, borcguncel = 0,burs=0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into tbl__ogr (ogrNo, Ad, Soyad, TCKN, Sehir, Burs, Fakulte, Ucret, Odeme,GuncelBorc)values (@e1, @e2, @e3, @e4, @e5, @e6, @e7, @e8, @e9,@e10)", baglanti);
            ekle.Parameters.AddWithValue("@e1",textOgrNo.Text);
            ekle.Parameters.AddWithValue("@e2",textAd.Text);
            ekle.Parameters.AddWithValue("@e3",textSoyad.Text);
            ekle.Parameters.AddWithValue("@e4",maskedTextTC.Text);
            ekle.Parameters.AddWithValue("@e5",comboSehir.Text);
            ekle.Parameters.AddWithValue("@e6",comboBurs.Text);
            ekle.Parameters.AddWithValue("@e7",comboFakulte.Text);
            ekle.Parameters.AddWithValue("@e9",textOdeme.Text);
            ucret = Convert.ToInt32(textUcret.Text);
            odeme = Convert.ToInt32(textOdeme.Text);
            burs = Convert.ToInt32(comboBurs.Text);
            ucret -= (ucret * burs) / 100;
            borcguncel = ucret - odeme;
            textUcret.Text = ucret.ToString();
            textGuncelBorc.Text = borcguncel.ToString();
            ekle.Parameters.AddWithValue("@e8", textUcret.Text);
            ekle.Parameters.AddWithValue("@e10", textGuncelBorc.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme Başarılı.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tbl__ogrTableAdapter.Fill(this._uni_kayitDataSet3.tbl__ogr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update tbl__ogr Set ad=@g2, soyad=@g3, tckn=@g4, sehir=@g5, burs=@g6, fakulte=@g7, ucret=@g8, odeme=@g9, guncelborc=@g10 where ogrno=@g1",baglanti);
            guncelle.Parameters.AddWithValue("@g1",textOgrNo.Text);
            guncelle.Parameters.AddWithValue("@g2",textAd.Text);
            guncelle.Parameters.AddWithValue("@g3",textSoyad.Text);
            guncelle.Parameters.AddWithValue("@g4",maskedTextTC.Text);
            guncelle.Parameters.AddWithValue("@g5",comboSehir.Text);
            guncelle.Parameters.AddWithValue("@g6",comboBurs.Text);
            guncelle.Parameters.AddWithValue("@g7",comboFakulte.Text);
            guncelle.Parameters.AddWithValue("@g8",textUcret.Text);
            guncelle.Parameters.AddWithValue("@g9", textOdeme.Text);
            odeme = Convert.ToInt32(textOdeme.Text);
            borcguncel -= odeme;
            textGuncelBorc.Text = borcguncel.ToString();
            guncelle.Parameters.AddWithValue("@g10", textGuncelBorc.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Başarıyla Güncellendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete from tbl__ogr where ogrno=@s1",baglanti);
            sil.Parameters.AddWithValue("@s1",textOgrNo.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrencinin kaydı silindi.");
        }

        private void textSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
