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
using HastaneOtomasyonu.BusinessLayer;

namespace HastaneOtomasyonu.UI.Hasta
{
    public partial class HastaListele : Form
    {
        public HastaListele()
        {
            InitializeComponent();
        }

        private void HastaListele_Load(object sender, EventArgs e)
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

        private void guncelle_Click(object sender, EventArgs e)
        {

            HastaDAL hasta = new HastaDAL();
            hasta.Update(ad.Text.ToString(), tel.Text.ToString(), email.Text.ToString(), Convert.ToInt32(ID.Text));
            dgv.DataSource = hasta.GetAll();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            HastaDAL hasta = new HastaDAL();
            int id = Convert.ToInt32(ID.Text);
            hasta.Delete(id);
            dgv.DataSource = hasta.GetAll();
        }

        private void goster_Click(object sender, EventArgs e)
        {
            
            Muayene goster = new Muayene();
            goster.Show();
        }
    }
}
