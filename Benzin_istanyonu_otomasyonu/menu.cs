using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benzin_istanyonu_otomasyonu
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            akaryakit_islemleri akar = new akaryakit_islemleri();
            akar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            satis sat = new satis();
            sat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musteri must = new musteri();
            must.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personel perso = new personel();
            perso.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
