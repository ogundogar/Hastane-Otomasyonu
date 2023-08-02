using HastaneOtomasyonu.UI.Hasta;
using HastaneOtomasyonu.UI.Personel;
using HastaneOtomasyonu.UI.Doktor;
using System;
using System.Windows.Forms;

namespace HastaneOtomasyonu.UI
{
    public partial class PersonelEkrani : Form
    {
        public PersonelEkrani()
        {
            InitializeComponent();
        }

        private void bttn_PersonelKayit_Click(object sender, EventArgs e)
        {
            PersonelKayit goruntule = new PersonelKayit();
            goruntule.Show();
        }

        private void bttn_DoktorKayit_Click(object sender, EventArgs e)
        {
            DoktorKayit goruntule = new DoktorKayit();
            goruntule.Show();
        }

        private void bttn_HastaKayit_Click(object sender, EventArgs e)
        {
            HastaKayit goruntule = new HastaKayit();
            goruntule.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandevuEkrani goruntule = new RandevuEkrani();
            goruntule.Show();
        }

        private void bttn_PersonelListesi_Click(object sender, EventArgs e)
        {
            PersonelListele goruntule = new PersonelListele();
            goruntule.Show();
        }

        private void bttn_DoktorListesi_Click(object sender, EventArgs e)
        {
            DoktorListele goruntule = new DoktorListele();
            goruntule.Show();
        }

        private void bttn_HastaListesi_Click(object sender, EventArgs e)
        {
            HastaListele goruntule = new HastaListele();
            goruntule.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuListe goster = new RandevuListe();
            goster.Show();
        }

        private void bttn_grafik_Click(object sender, EventArgs e)
        {
            Zedgraph grafik = new Zedgraph();
            grafik.Show();
        }
    }
}
