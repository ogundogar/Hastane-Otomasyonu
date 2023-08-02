using HastaneOtomasyonu.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu.BusinessLayer.KisilerDAL
{
    public class HastaDAL
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hastane.mdb");
        public List<Kisiler> GetAll()
        {
           
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            OleDbCommand command = new OleDbCommand("Select * from Kisiler where Sinif like '%" + "Hasta" + "%'", connection);
                                                                                         

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
                    Sinif =Convert.ToString(reader["Sinif"]),
                    Brans = Convert.ToString(reader["Brans"])

                };
                kisi.Add(kisiler);
            }
            reader.Close();
            connection.Close();
            return kisi;
        }
        public void Add(string ad, string tel, string email)
        {
            
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            Kisiler kisiler = new Kisiler
            {
                AdSoyad = ad,
                TelefonNo = tel,
                Email = email,
                Sifre = "0",
                Sinif = "Hasta",
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

        public void Update(string ad, string tel, string email,int ID)
        {
            
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            Kisiler kisiler = new Kisiler
            { KisilerID = ID,
                AdSoyad = ad,
                TelefonNo = tel,
                Email = email,
                Sifre = "0",
                Sinif = "Hasta",
                Brans = "Yok"
            };
            OleDbCommand command = new OleDbCommand("UPDATE Kisiler SET AdSoyad = @AdSoyad,Email = @Email, TelefonNo =@TelefonNo,Brans = @Brans, Sinif =@Sinif,Sifre =@Sifre WHERE KisilerID = @KisilerID", connection);
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
    }
}
