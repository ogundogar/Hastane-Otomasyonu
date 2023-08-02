using HastaneOtomasyonu.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;

using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HastaneOtomasyonu.BusinessLayer.KisilerDAL
{
    public class PersonelDAL
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hastane.mdb");
        public List<Kisiler> Personel_GetAll()
        {
           
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            OleDbCommand command = new OleDbCommand("Select * from Kisiler where Sinif like '%"+"Personel"+"%'", connection);
                                                                                         

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
                    Sinif = "Personel"
                };
                kisi.Add(kisiler);
            }
            reader.Close();
            connection.Close();
            return kisi;
        }
        public void Add(string ad, string tel, string email,string sifre)
        {
           
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            Kisiler kisiler = new Kisiler
            {
                AdSoyad = ad,
                TelefonNo = tel,
                Email = email,
                Sifre = sifre,
                Sinif = "Personel",
                Brans = "Yok"
            };
            OleDbCommand command = new OleDbCommand("insert into Kisiler (AdSoyad,Email,TelefonNo,Brans,Sinif,Sifre)values(@AdSoyad,@Email,@TelefonNo,@Brans,@Sinif,@Sifre)", connection);
            command.Parameters.AddWithValue("@AdSoyad", kisiler.AdSoyad);
            command.Parameters.AddWithValue("@Email", kisiler.Email);
            command.Parameters.AddWithValue("@TelefonNo", kisiler.TelefonNo);
            command.Parameters.AddWithValue("@Brans", kisiler.Brans);
            command.Parameters.AddWithValue("@Sinif", kisiler.Sinif);
            command.Parameters.AddWithValue("@Sifre", kisiler.Sifre);
           
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(string ad, string tel, string email, string sifre,int ID)
        {
          
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            Kisiler kisiler = new Kisiler
            {KisilerID=ID,
                AdSoyad = ad,
                TelefonNo = tel,
                Email = email,
                Sifre = sifre,
                Sinif = "Personel",
                Brans = "Yok"
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
        public bool giris(string sifre, string email)
        {
            
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            OleDbCommand command = new OleDbCommand("Select * from Kisiler Where sifre like '" + sifre + "'and Sinif='" + "Personel" + "'and Email='" + email + "'", connection);


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



