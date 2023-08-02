using HastaneOtomasyonu.BusinessLayer;
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
    public partial class RandevuListe : Form
    {
        public RandevuListe()
        {
            InitializeComponent();
        }

        private void RandevuListe_Load(object sender, EventArgs e)
        {

            RandevuDAL hasta = new RandevuDAL();
            dgv.DataSource = hasta.GetAll();
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            ad.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            email.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            tel.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            tarih.Text = dgv.CurrentRow.Cells[5].Value.ToString();
            saat.Text = dgv.CurrentRow.Cells[6].Value.ToString();
            bolum.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            doktoradi.Text = dgv.CurrentRow.Cells[7].Value.ToString();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            RandevuDAL hasta = new RandevuDAL();
            hasta.Update(ad.Text.ToString(), tel.Text.ToString(), email.Text.ToString(), Convert.ToInt32(ID.Text),bolum.Text.ToString(), tarih.Text.ToString(), saat.Text.ToString(),doktoradi.Text.ToString());
            dgv.DataSource = hasta.GetAll();
        }

        private void goster_Click(object sender, EventArgs e)
        {
            Muayene goster = new Muayene();
            goster.hasta(Convert.ToInt32(ID.Text), ad.Text.ToString(), doktoradi.Text.ToString(), tarih.Text.ToString(), saat.Text.ToString(), bolum.Text.ToString(),tel.Text.ToString(),email.Text.ToString());
            goster.Show();
            this.Close();
        }
    }
}
