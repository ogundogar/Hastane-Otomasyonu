using HastaneOtomasyonu.DataLayer;

using System;
using System.Collections.Generic;

using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace HastaneOtomasyonu.BusinessLayer.KisilerDAL
{
    public class DoktorDAL
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hastane.mdb");
        double cildiye = 0, KulakBurunBogaz = 0, Dahiliye = 0, uroloji = 0, Psikoloji = 0;
        public List<Kisiler> GetAll()
        {
           
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            OleDbCommand command = new OleDbCommand("Select * from Kisiler where Sinif like '%" + "Doktor" + "%'", connection);
                                                                                        

            OleDbDataReader reader = command.ExecuteReader();

            List<Kisiler> kisi = new List<Kisiler>();
           
            while (reader.Read())
            {
                Kisiler kisiler = new Kisiler
                {
                    KisilerID = Convert.ToInt32(reader["KisilerID"]),
                    AdSoyad = reader["AdSoyad"].ToString(),
                    Email = Convert.ToString(reader["Email"]),
                    TelefonNo = Convert.ToString(reader["TelefonNo"]),
                    Brans=Convert.ToString(reader["Brans"]),
                    Sinif = Convert.ToString(reader["Sinif"])
                };
                if (kisiler.Brans=="Cildiye")
                {
                    cildiye++;
                }
                else if (kisiler.Brans=="Dahiliye") 
                {
                    Dahiliye++;
                }
                else if (kisiler.Brans == "Kulak-Burun-Boğaz")
                {
                    KulakBurunBogaz++;
                }
                else if (kisiler.Brans == "Üroloji")
                {
                    uroloji++;
                }
                else if (kisiler.Brans == "Psikoloji")
                {
                    Psikoloji++;
                }
                kisi.Add(kisiler);
            }
            reader.Close();
            connection.Close();
            return kisi;
        }
        public double[] doktorsayisi() {
            double[] doktorsayisi = new double[5];
            doktorsayisi[0] = cildiye;
            doktorsayisi[1] = KulakBurunBogaz;
            doktorsayisi[2] = Dahiliye;
            doktorsayisi[3] = Psikoloji;
            doktorsayisi[4] = uroloji;
            return doktorsayisi;
        } 
        public void Add(string ad, string tel, string email, string sifre, string brans,string sinif)
        {
            
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            Kisiler kisiler = new Kisiler
            {
                AdSoyad = ad,
                TelefonNo = tel,
                Email = email,
                Sifre = sifre,
                Sinif = sinif,
                Brans = brans
            };
            OleDbCommand command = new OleDbCommand("insert into Kisiler (AdSoyad,Email,TelefonNo,Brans,Sinif,Sifre)values(@AdSoyad,@Email,@TelefonNo,@Brans,@Sinif,@Sifre)", connection);
            command.Parameters.AddWithValue("@Email", kisiler.Email);
            command.Parameters.AddWithValue("@TelefonNo", kisiler.TelefonNo);
            command.Parameters.AddWithValue("@Brans", kisiler.Brans);
            command.Parameters.AddWithValue("@Sinif", kisiler.Sinif);
            command.Parameters.AddWithValue("@Sifre", kisiler.Sifre);
            command.Parameters.AddWithValue("@AdSoyad", kisiler.AdSoyad);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(string ad, string tel, string email, string sifre,string brans,int ID)
        {
            
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            Kisiler kisiler = new Kisiler
            {
                KisilerID = ID,
                AdSoyad = ad,
                TelefonNo = tel,
                Email = email,
                Sifre = sifre,
                Sinif = "Doktor",
                Brans=brans
            };
            OleDbCommand command = new OleDbCommand("UPDATE Kisiler SET AdSoyad = @AdSoyad,Email = @Email, TelefonNo =@TelefonNo,Brans = @Brans, Sinif =@Sinif,Sifre =@Sifre WHERE KisilerID = @KisilerID", connection);//veri tabanındaki satırdaki verileri güncellemek için id numarası isteriz.id numarasına ayit veriler değişir..
            command.Parameters.AddWithValue("@AdSoyad", kisiler.AdSoyad);
            command.Parameters.AddWithValue("@Email", kisiler.Email);
            command.Parameters.AddWithValue("@TelefonNo", kisiler.TelefonNo);
            command.Parameters.AddWithValue("@Brans", kisiler.Brans);
            command.Parameters.AddWithValue("@Sinif", kisiler.Sinif);
            command.Parameters.AddWithValue("@Sifre", kisiler.Sifre);
            command.Parameters.AddWithValue("@KisilerID", kisiler.KisilerID);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int ID)
        {
            
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            OleDbCommand command = new OleDbCommand("DELETE * FROM Kisiler WHERE KisilerID = @KisilerID", connection);
            command.Parameters.AddWithValue("@KisilerID", ID);

            command.ExecuteNonQuery();
            connection.Close();
        }
        public bool giris(string sifre,string email)
        {
            
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            OleDbCommand command = new OleDbCommand("Select * from Kisiler Where sifre like '" + sifre + "'and Sinif='" + "Doktor" + "'and Email='" +email+"'", connection);


            OleDbDataReader reader = command.ExecuteReader();
            bool girisyapabilir = false;
            if (reader.Read())
            {
                girisyapabilir = true;
            }
            reader.Close();
            connection.Close();
            return girisyapabilir;
        }
    }
}
