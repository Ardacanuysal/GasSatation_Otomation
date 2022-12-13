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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ARDACANUYSAA1BA;Initial Catalog=Otomasyon;Integrated Security=True");
        DataTable tablo = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from admin where kullanici_adi='" + textBox1.Text + "' and sifre ='" + textBox2.Text + "'", baglanti);
            
            baglanti.Open();

            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read()) { 
                MessageBox.Show("Giriş Başarılı !");
                baglanti.Close();
                menu menu = new menu();
                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız Yada Şifreniz Yanlış Yazılmıştır");
                textBox1.Text = "";
                textBox2.Text = "";
                baglanti.Close();
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
