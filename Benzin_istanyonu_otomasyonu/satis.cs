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
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ARDACANUYSAA1BA;Initial Catalog=Otomasyon;Integrated Security=True");
        DataTable tablo = new DataTable();


        public void listele()
        {
            textBox1.Text = "";
            textBox2.Text = "0";
            textBox3.Text = "0";
            comboBox1.Text = "";
            comboBox2.Text = "";
            label9.Text = "0";
            label8.Text = "0";
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].Visible = false;
            baglanti.Close();
        }
        private void satis_Load(object sender, EventArgs e)
        {
            listele();
            SqlCommand komut = new SqlCommand("select * from musteri", baglanti);
            
            baglanti.Open();

            SqlDataReader oku = komut.ExecuteReader();
          while (oku.Read())
            {

                comboBox1.Items.Add(oku.GetValue(1));

            }
            baglanti.Close();
            
            SqlCommand komut2 = new SqlCommand("select * from depo", baglanti);
           
            baglanti.Open();

            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {

                comboBox2.Items.Add(oku2.GetValue(1));

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=ARDACANUYSAA1BA;Initial Catalog=Otomasyon;Integrated Security=True");
               
                SqlCommand komut = new SqlCommand("select * from musteri where tc='" + comboBox1.Text + "'", baglanti);
                
                baglanti.Open();
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {

                    textBox1.Text = oku.GetValue(7).ToString();

                }
            }
            catch 
            {

                ;
            }
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=ARDACANUYSAA1BA;Initial Catalog=Otomasyon;Integrated Security=True");
                
                SqlCommand komut = new SqlCommand("select * from depo where akaryakit_adi='" + comboBox2.Text + "'", baglanti);
                
                baglanti.Open();

                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {

                    textBox2.Text = oku.GetValue(3).ToString();
                    label8.Text = oku.GetValue(2).ToString();
                }
            }
            catch
            {

                ;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int depodaolan, satilan,sonkalan = 0;
            depodaolan = int.Parse(textBox2.Text);
            satilan = int.Parse(textBox3.Text);
            if (depodaolan>satilan)
            {

                if (baglanti.State == ConnectionState.Open)
                {

                    baglanti.Close();
                }
                baglanti.Open();

                SqlCommand kmt;

                kmt = new SqlCommand
                ("INSERT INTO satis(arac_plaka,akaryakit_turu,satilan_litre,fiyat,tarih) values('" + textBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','"+label9.Text+"','"+DateTime.Now.ToShortDateString()+"')", baglanti);
                kmt.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış İşlemi Başarılı");

                sonkalan = depodaolan - satilan;

                SqlCommand kmt2;
                baglanti.Open();
                kmt2 = new SqlCommand("UPDATE depo SET depo_kalan='" + sonkalan.ToString() + "'where akaryakit_adi='" + comboBox2.Text + "'", baglanti);
                kmt2.ExecuteNonQuery();
                baglanti.Close();
                listele();

            }
            else
            {
                textBox3.Text = "0";
                MessageBox.Show("Depodaki Kapasiteden Fazla Satmayı Deniyorsunuz ! ");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label9.Text = (int.Parse(label8.Text) * int.Parse(textBox3.Text)).ToString();
            }
            catch (Exception hata)
            {
                textBox3.Text = "1";
                MessageBox.Show(hata.Message);
                
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
