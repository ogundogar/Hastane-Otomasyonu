using HastaneOtomasyonu.BusinessLayer;
using HastaneOtomasyonu.BusinessLayer.KisilerDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu.UI.Hasta
{
    public partial class RandevuEkrani : Form
    {
        public RandevuEkrani()
        {
            InitializeComponent();
        }

        private void bttn_Kaydet_Click(object sender, EventArgs e)
        {
            RandevuDAL dal = new RandevuDAL();

            dal.Add(ad.Text.ToString(), tel.Text.ToString(), email.Text.ToString(), tarih.Text.ToString(), saat.Text.ToString(), bolum.Text.ToString(), doktoradi.Text.ToString());
            RandevuListe goster = new RandevuListe();
            goster.Show();
            this.Close();
        }

        private void RandevuEkrani_Load(object sender, EventArgs e)
        {

            HastaDAL hasta = new HastaDAL();
            dgv.DataSource = hasta.GetAll();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            ad.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            email.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            tel.Text = dgv.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
