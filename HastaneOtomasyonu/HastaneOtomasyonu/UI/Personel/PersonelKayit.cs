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
using HastaneOtomasyonu.UI.Personel;

namespace HastaneOtomasyonu.UI
{
    public partial class PersonelKayit : Form
    {
        public PersonelKayit()
        {
            InitializeComponent();
        }

        private void bttn_Kaydet_Click(object sender, EventArgs e)
        {
            PersonelDAL personel = new PersonelDAL();
            string Ad = ad.Text.ToString();
            string Tel = tel.Text.ToString();
            string Email = email.Text.ToString();
            string Sifre = sifre.Text.ToString();
            string Sinif = txt_personel.Text.ToString();
            personel.Add(Ad,Tel,Email,Sifre);
            PersonelListele goruntule = new PersonelListele();
            goruntule.Show();
           
            this.Close();

        }
    }
}
