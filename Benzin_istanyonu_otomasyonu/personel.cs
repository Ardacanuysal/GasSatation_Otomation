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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        SqlConnection baglan = new SqlConnection("Data Source=ARDACANUYSAA1BA;Initial Catalog=Otomasyon;Integrated Security=True");
        DataTable tablo = new DataTable();
     
        public void listele()
        {
            txt_AdSoyad.Text = "";
            txt_Email.Text = "";
            txt_Maas.Text = "";
            mskd_DogumTarihi.Text = "";
            cmb_Position.Text = "";
           
            mskd_TelefonNumarasi.Text = "";
            txt_Tc.Text = "";
            tablo.Clear();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter
          ("select * from personel", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            baglan.Close();
        }

        private void personel_Load(object sender, EventArgs e)
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
            ("INSERT INTO personel(tc,adi_soyadi,dogum_tarihi,tel,email,pozisyon,maas) values('"+txt_Tc.Text+"','" + txt_AdSoyad.Text + "','" + mskd_DogumTarihi.Text + "','" + mskd_TelefonNumarasi.Text + "','" + txt_Email.Text + "','" + cmb_Position.Text + "','" + txt_Maas.Text + "')", baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Başarılı");
            listele();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

            SqlCommand kmt;
            baglan.Open();
            kmt = new SqlCommand("Delete from personel where tc = '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", baglan);
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
            kmt = new SqlCommand("UPDATE personel SET tc='" + txt_Tc.Text + "',adi_soyadi='" + txt_AdSoyad.Text + "',dogum_tarihi='" + mskd_DogumTarihi.Text + "',tel='" + mskd_TelefonNumarasi.Text + "',email='" + txt_Email.Text + "',pozisyon='" + cmb_Position.Text + "',maas='" + txt_Maas.Text + "'where tc='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("İşleminiz başarılı");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Tc.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_AdSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mskd_DogumTarihi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mskd_TelefonNumarasi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmb_Position.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_Maas.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
         
            tablo.Clear();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter
          ("select * from personel where tc='"+txt_SearchTc.Text+"'", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            baglan.Close();
            txt_SearchTc.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
