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

namespace HastaneOtomasyonu.UI.Doktor
{
    public partial class DoktorListele : Form
    {
        public DoktorListele()
        {
            InitializeComponent();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            DoktorDAL doktor = new DoktorDAL();
            doktor.Update(ad.Text.ToString(), tel.Text.ToString(), email.Text.ToString(), 
                sifre.Text.ToString(),cbx.Text.ToString(),Convert.ToInt32(ID.Text));
            dgv.DataSource = doktor.GetAll();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DoktorDAL doktor = new DoktorDAL();
            int id = Convert.ToInt32(ID.Text);
            doktor.Delete(id);
            dgv.DataSource = doktor.GetAll();

        }

        private void DoktorListele_Load(object sender, EventArgs e)
        {
            DoktorDAL doktor = new DoktorDAL();
            dgv.DataSource = doktor.GetAll();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            ad.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            tel.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            email.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            cbx.Text = dgv.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
