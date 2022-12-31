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
    public partial class akaryakit_islemleri : Form
    {
        public akaryakit_islemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=ARDACANUYSAA1BA;Initial Catalog=Otomasyon;Integrated Security=True");
        DataTable tablo = new DataTable();
        public void listele()
        {
            txt_AkarYakitAdi.Text = "";
            txt_LitreFiyati.Text = "";
            txt_Depo.Text = "";

            tablo.Clear();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from depo", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            baglan.Close();
        }

        private void akaryakit_islemleri_Load(object sender, EventArgs e)
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

            SqlCommand kmt = new SqlCommand("INSERT INTO depo(akaryakit_adi,litre_fiyati,depo_kalan) values('" + txt_AkarYakitAdi.Text + "','" + txt_LitreFiyati.Text + "','" + txt_Depo.Text + "')", baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Başarılı");
            listele();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

            SqlCommand kmt;
            baglan.Open();
            kmt = new SqlCommand("Delete from depo where akaryakit_adi = '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", baglan);
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
            kmt = new SqlCommand("UPDATE depo SET akaryakit_adi='" + txt_AkarYakitAdi.Text + "',litre_fiyati='" + txt_LitreFiyati.Text + "',depo_kalan='" + txt_Depo.Text + "'where akaryakit_adi='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("İşleminiz başarılı");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_AkarYakitAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_LitreFiyati.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Depo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_SearchAkaryakitAdi_Click(object sender, EventArgs e)
        {

            tablo.Clear();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from depo where akaryakit_adi='" + txt_SearchAkaryakitAdi.Text + "'", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            baglan.Close();
            txt_SearchAkaryakitAdi.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_AkarYakitAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
