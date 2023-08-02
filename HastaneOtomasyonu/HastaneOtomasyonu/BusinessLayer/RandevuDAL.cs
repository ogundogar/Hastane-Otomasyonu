using HastaneOtomasyonu.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.BusinessLayer
{
    public class RandevuDAL
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hastane.mdb");
        public List<Randevu> GetAll()
        {
           
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            OleDbCommand command = new OleDbCommand("Select * from Randevu", connection);


            OleDbDataReader reader = command.ExecuteReader();

            List<Randevu> kisi = new List<Randevu>();
            while (reader.Read())
            {
                Randevu kisiler = new Randevu
                {
                    RandevuID = Convert.ToInt32(reader["RandevuID"]),
                    AdSoyad = reader["AdSoyad"].ToString(),
                    Email = Convert.ToString(reader["Email"]),
                    TelefonNo = Convert.ToString(reader["TelefonNo"]),
                    Bolum = Convert.ToString(reader["Bolum"]),
                    RandevuTarihi = Convert.ToString(reader["RandevuTarihi"]),
                    RandevuSaati = Convert.ToString(reader["RandevuSaati"]),
                    Doktor = Convert.ToString(reader["Doktor"])


                };
                kisi.Add(kisiler);
            }
            reader.Close();
            connection.Close();
            return kisi;
        }
        public void Add(string ad, string tel, string email, string tarih, string saat, string bolum,string doktor)
        {
            
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            Randevu kisiler = new Randevu
            {

                AdSoyad = ad,
                Email = email,
                TelefonNo = tel,
                Bolum = bolum,
                RandevuTarihi = tarih,
                RandevuSaati = saat,
                Doktor=doktor,
              
            };
            OleDbCommand command = new OleDbCommand("insert into Randevu (AdSoyad,Email,TelefonNo,Bolum,RandevuTarihi,RandevuSaati,Doktor)values(@AdSoyad,@Email,@TelefonNo,@Bolum,@RandevuTarihi,@RandevuSaati,Doktor)", connection);//veri tabanındaki sütunlara veri eklemek için
            command.Parameters.AddWithValue("@AdSoyad", kisiler.AdSoyad);
            command.Parameters.AddWithValue("@Email", kisiler.Email);
            command.Parameters.AddWithValue("@TelefonNo", kisiler.TelefonNo);
            command.Parameters.AddWithValue("@Bolum", kisiler.Bolum);
            command.Parameters.AddWithValue("@RandevuTarihi", kisiler.RandevuTarihi);
            command.Parameters.AddWithValue("@RandevuSaati", kisiler.RandevuSaati);
            command.Parameters.AddWithValue("@Doktor", kisiler.Doktor);
            command.ExecuteNonQuery();
            connection.Close();
        }


        public void Update(string ad, string tel, string email, int ID, string bolum, string tarih, string saat,string doktor)
        {
            
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            Randevu kisiler = new Randevu
            {
                RandevuID = ID,
                AdSoyad = ad,
                Email = email,
                TelefonNo = tel,
                Bolum = bolum,
                RandevuTarihi = tarih,
                RandevuSaati = saat,
                Doktor=doktor

            };
            OleDbCommand command = new OleDbCommand("UPDATE Randevu SET AdSoyad = @AdSoyad,Email = @Email, TelefonNo =@TelefonNo,Bolum = @Bolum, RandevuTarihi =@RandevuTarihi,RandevuSaati =@RandevuSaati,Doktor=@Doktor WHERE RandevuID = @RandevuID", connection);
            command.Parameters.AddWithValue("@AdSoyad", kisiler.AdSoyad);
            command.Parameters.AddWithValue("@Email", kisiler.Email);
            command.Parameters.AddWithValue("@TelefonNo", kisiler.TelefonNo);
            command.Parameters.AddWithValue("@Bolum", kisiler.Bolum);
            command.Parameters.AddWithValue("@RandevuTarihi", kisiler.RandevuTarihi);
            command.Parameters.AddWithValue("@RandevuSaati", kisiler.RandevuSaati);
            command.Parameters.AddWithValue("@Doktor", kisiler.Doktor);
            command.Parameters.AddWithValue("@RandevuID", kisiler.RandevuID);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(int ID)
        {
           
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            OleDbCommand command = new OleDbCommand("DELETE * FROM Randevu WHERE RandevuID = @RandevuID", connection);
            command.Parameters.AddWithValue("@RandevuID", ID);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

