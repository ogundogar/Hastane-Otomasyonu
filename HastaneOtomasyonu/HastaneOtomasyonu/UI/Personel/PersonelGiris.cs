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
using HastaneOtomasyonu.DataLayer;
using HastaneOtomasyonu.UI.Hasta;

namespace HastaneOtomasyonu.UI.Personel
{
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void bttn_tamam_Click(object sender, EventArgs e)
        {
            PersonelDAL dal = new PersonelDAL();
            
            if (dal.giris(txt_sifre.Text.ToString(), txt_email.Text.ToString()))
            {
                PersonelEkrani goruntule = new PersonelEkrani();
                goruntule.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }

        }
    }
}
