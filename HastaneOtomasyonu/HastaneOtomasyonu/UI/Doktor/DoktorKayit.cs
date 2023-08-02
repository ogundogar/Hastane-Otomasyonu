using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneOtomasyonu.BusinessLayer.KisilerDAL;
using HastaneOtomasyonu.UI.Doktor;

namespace HastaneOtomasyonu.UI
{
    public partial class DoktorKayit : Form
    {
        public DoktorKayit()
        {
            InitializeComponent();
        }

        private void bttn_Kaydet_Click(object sender, EventArgs e)
        {
            DoktorDAL doktor = new DoktorDAL();
            doktor.Add(ad.Text.ToString(), tel.Text.ToString(), email.Text.ToString(), 
                brans.Text.ToString(), sifre.Text.ToString(), txt_Doktor.Text.ToString());
            DoktorListele goruntule = new DoktorListele();
            goruntule.Show();
            this.Close();

        }
    }
}
