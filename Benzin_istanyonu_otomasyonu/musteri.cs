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

namespace Benzin_istanyonu_otomasyonu
{
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=ARDACANUYSAA1BA;Initial Catalog=Otomasyon;Integrated Security=True");
        DataTable tablo = new DataTable();
        public void listele()
        {
            txt_AdSoyad.Text = "";
            txt_Email.Text = "";
            txt_Plaka.Text = "";
            mskd_DogumTarihi.Text = "";
            Cmb_Email.Text = "";

            mskd_TelefonNumber.Text = "";
            mskd_Tc.Text = "";
            tablo.Clear();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter
          ("select * from musteri", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            baglan.Close();
        }

        private void musteri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {

            if (baglan.State == ConnectionState.Open)
            {

                baglan.Close();
            }
            baglan.Open();

            SqlCommand kmt;

            kmt = new SqlCommand
            ("INSERT INTO musteri(tc,adi_soyadi,dogum_tarihi,tel,email,uyelik_durumu,plaka) values('" + mskd_Tc.Text + "','" + txt_AdSoyad.Text + "','" + mskd_DogumTarihi.Text + "','" + mskd_TelefonNumber.Text + "','" + txt_Email.Text + "','" + Cmb_Email.Text + "','" + txt_Plaka.Text + "')", baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Başarılı");
            listele();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

            SqlCommand kmt;
            baglan.Open();
            kmt = new SqlCommand("Delete from musteri where tc = '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", baglan);
            kmt.ExecuteNonQuery();
            kmt.Dispose();
            baglan.Close();
            MessageBox.Show("İşleminiz başarılı");
            listele();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

            SqlCommand kmt;
            baglan.Open();
            kmt = new SqlCommand("UPDATE musteri SET tc='" + mskd_Tc.Text + "',adi_soyadi='" + txt_AdSoyad.Text + "',dogum_tarihi='" + mskd_DogumTarihi.Text + "',tel='" + mskd_TelefonNumber.Text + "',email='" + txt_Email.Text + "',uyelik_durumu='" + Cmb_Email.Text + "',plaka='" + txt_Plaka.Text + "'where tc='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("İşleminiz başarılı");
            listele();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {

            tablo.Clear();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter
          ("select * from musteri where tc='" + txt_TcSearch.Text + "'", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            baglan.Close();
            txt_TcSearch.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mskd_Tc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_AdSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mskd_DogumTarihi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskd_TelefonNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Cmb_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_Plaka.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_TcSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskd_DogumTarihi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
          
            }
        }
    }

