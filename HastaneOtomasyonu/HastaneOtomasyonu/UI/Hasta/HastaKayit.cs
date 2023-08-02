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
using HastaneOtomasyonu.UI.Hasta;

namespace HastaneOtomasyonu.UI
{
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }

        private void bttn_Kaydet_Click(object sender, EventArgs e)
        {
            HastaDAL hasta = new HastaDAL();
            hasta.Add(ad.Text.ToString(), tel.Text.ToString(), email.Text.ToString());
            HastaListele goruntule = new HastaListele();
            goruntule.Show();
            this.Close();

        }
    }
}