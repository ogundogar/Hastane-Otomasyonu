using HastaneOtomasyonu.UI;
using HastaneOtomasyonu.UI.Doktor;
using HastaneOtomasyonu.UI.Personel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void bttn_Personel_Click_1(object sender, EventArgs e)
        {

            PersonelGiris giris = new PersonelGiris();
            giris.Show();
        }

        private void bttn_Doktor_Click_1(object sender, EventArgs e)
        {
            DoktorGiris goruntule = new DoktorGiris();
            goruntule.Show();
        }
    }
}
