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
using ZedGraph;

namespace HastaneOtomasyonu.UI
{
    public partial class Zedgraph : Form
    {
        public Zedgraph()
        {
            InitializeComponent();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
        
            
        }

        private void Zedgraph_Load(object sender, EventArgs e)
        {
            double[] dizi1 = new double[5];
            dizi1[0] = 1;
            dizi1[1] = 2;
            dizi1[2] = 3;
            dizi1[3] = 4;
            dizi1[4] = 5;
            DoktorDAL doktor = new DoktorDAL();
            doktor.GetAll();
           double[] dizi2 = doktor.doktorsayisi();
           
            zedGraphControl1.GraphPane.Title.Text = $"Bölümlere Göre Hasta Sayısı";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "Bölümler";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "Hasta Sayısı";
            zedGraphControl1.GraphPane.AddBar("Bölümler", dizi1,dizi2, Color.Red);

        }
    }
}
