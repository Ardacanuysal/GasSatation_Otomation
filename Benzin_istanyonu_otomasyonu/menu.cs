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

        private void Btn_Akaryakit_Click(object sender, EventArgs e)
        {
            akaryakit_islemleri akar = new akaryakit_islemleri();
            akar.Show();
        }

        private void Btn_Satis_Click(object sender, EventArgs e)
        {
            satis sat = new satis();
            sat.Show();
        }

        private void btn_Musteri_Click(object sender, EventArgs e)
        {
            musteri must = new musteri();
            must.Show();
        }

        private void Btn_Personel_Click(object sender, EventArgs e)
        {
            personel perso = new personel();
            perso.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
