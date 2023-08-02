using HastaneOtomasyonu.BusinessLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using HastaneOtomasyonu.UI.Hasta;

namespace HastaneOtomasyonu.UI
{
    public partial class Muayene : Form
    {
        public Muayene()
        {
            InitializeComponent();
        }
        string  ad, doktor,rtarih,rsaat,rbolum,tel,email;

        private void bttn_email_Click(object sender, EventArgs e)
        {
           
        }

        private void bttn_PDF_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document rapor = new iTextSharp.text.Document();
            PdfWriter.GetInstance(rapor, new FileStream("C:\\Users\\User\\Desktop\\HastaneOtomasyonu\\Deneme.Pdf", FileMode.Create));
            rapor.AddAuthor(_HastaAdi.Text);
            rapor.AddCreationDate();
            rapor.AddCreator(_doktoradi.Text);
            rapor.AddSubject(_bolum.Text);
            rapor.AddKeywords(_tarih.Text);
            rapor.AddKeywords(_saat.Text);
            if (rapor.IsOpen()==false)
            {
                rapor.Open();
            }
            rapor.Add(new Paragraph("Hasta Adı :"+_HastaAdi.Text));
            rapor.Add(new Paragraph("Doktor Adı :"+_doktoradi.Text));
            rapor.Add(new Paragraph("Bölüm Adı :"+_bolum.Text));
            rapor.Add(new Paragraph("Randevu Tarihi :" + _tarih.Text));
            rapor.Add(new Paragraph("Randevu Saati :" + _saat.Text));
            rapor.Add(new Paragraph("Doktor Görüşü"));
            rapor.Add(new Paragraph(_info.Text));
            rapor.Close();
            MessageBox.Show("Oluşturuldu...");
        }

        MuayaneDAL dal = new MuayaneDAL();
        private void bttn_Onayla_Click(object sender, EventArgs e)
        {
            dal.Add(
               
                _HastaAdi.Text.ToString(),
                tel,
                email, 
                _doktoradi.Text.ToString(),
                _bolum.Text.ToString(),
                _tarih.Text.ToString(),
                _saat.Text.ToString(),
                _info.Text.ToString()
                );
            RandevuListe goster = new RandevuListe();
            goster.Show();
            this.Close();
        }

        int id;
        private void Muayene_Load(object sender, EventArgs e)
        {
          
            _id.Text = id.ToString();
            _saat.Text = rsaat;
            _tarih.Text = rtarih;
            _bolum.Text = rbolum;
            _doktoradi.Text = doktor;
            _HastaAdi.Text = ad;
        }
        public void hasta(int ID,string Ad, string Doktor, string Rtarih, string Rsaat, string Rbolum,string Tel,string Email)
        {
            id = ID;
            ad = Ad;
            doktor = Doktor;
            rtarih = Rtarih;
            rsaat = Rsaat;
            rbolum = Rbolum;
            tel = Tel;
            email = Email;
        }
    }
}
