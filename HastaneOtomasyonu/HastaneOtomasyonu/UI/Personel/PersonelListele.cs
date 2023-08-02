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


namespace HastaneOtomasyonu.UI.Personel
{
    public partial class PersonelListele : Form
    {
        public PersonelListele()
        {
            InitializeComponent();
        }

        private void PersonelListele_Load(object sender, EventArgs e)
        {
            PersonelDAL personel = new PersonelDAL();
            dgv.DataSource = personel.Personel_GetAll();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dgv.CurrentRow.Cells[3].Value.ToString();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            PersonelDAL personel = new PersonelDAL();
            personel.Update(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox4.Text.ToString(),sifre.Text.ToString(),Convert.ToInt32(ID.Text));
            dgv.DataSource = personel.Personel_GetAll();

        }

        private void sil_Click(object sender, EventArgs e)
        {
            PersonelDAL personel = new PersonelDAL();
            int id = Convert.ToInt32(ID.Text);
            personel.Delete(id);
            dgv.DataSource = personel.Personel_GetAll();

        }
    }
}
