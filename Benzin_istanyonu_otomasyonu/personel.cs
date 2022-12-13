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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        SqlConnection baglan = new SqlConnection("Data Source=ARDACANUYSAA1BA;Initial Catalog=Otomasyon;Integrated Security=True");
        DataTable tablo = new DataTable();
     
        public void listele()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.Text = "";
           
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (baglan.State == ConnectionState.Open)
            {

                baglan.Close();
            }
            baglan.Open();

            SqlCommand kmt;

            kmt = new SqlCommand
            ("INSERT INTO personel(tc,adi_soyadi,dogum_tarihi,tel,email,pozisyon,maas) values('"+maskedTextBox3.Text+"','" + textBox1.Text + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "')", baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Başarılı");
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand kmt;
            baglan.Open();
            kmt = new SqlCommand("UPDATE personel SET tc='" + maskedTextBox3.Text + "',adi_soyadi='" + textBox1.Text + "',dogum_tarihi='" + maskedTextBox1.Text + "',tel='" + maskedTextBox2.Text + "',email='" + textBox2.Text + "',pozisyon='" + comboBox1.Text + "',maas='" + textBox3.Text + "'where tc='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("İşleminiz başarılı");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
            tablo.Clear();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter
          ("select * from personel where tc='"+textBox4.Text+"'", baglan);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            baglan.Close();
            textBox4.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
