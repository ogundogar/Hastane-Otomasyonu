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
    public class MuayaneDAL
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Hastane.mdb");
        public List<HastaBilgi> GetAll()
        {
           
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            OleDbCommand command = new OleDbCommand("Select * from HastaBilgi", connection);
                                                                                                                              

            OleDbDataReader reader = command.ExecuteReader();

            List<HastaBilgi> kisi = new List<HastaBilgi>();
            while (reader.Read())
            {
                HastaBilgi kisiler = new HastaBilgi
                {
                    HastaID = Convert.ToInt32(reader["KisilerID"]),
                    HastaAdSoyad = reader["HastaAdSoyad"].ToString(),
                    TelefonNo = Convert.ToString(reader["TelefonNo"]),
                    Email = Convert.ToString(reader["Email"]),
                    DoktorAdi = Convert.ToString(reader["DoktorAdi"]),
                    Bolum = Convert.ToString(reader["Bolum"]),
                    RandevuTarihi = Convert.ToString(reader["RandevuTarihi"]),
                    RandevuSaati = Convert.ToString(reader["RandevuSaati"]),
                    HastaInfo = Convert.ToString(reader["HastaInfo"])

                };
                kisi.Add(kisiler);
            }
            reader.Close();
            connection.Close();
            return kisi;
        }
       
        
        public void Add( string ad, string tel, string email, string doktoradi, string bolum, string tarih, string saat, string info)
        {
          
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            HastaBilgi kisiler = new HastaBilgi
            {

               
                HastaAdSoyad = ad,
                TelefonNo = tel,
                Email = email,
                DoktorAdi = doktoradi,
                Bolum = bolum,
                RandevuTarihi = tarih,
                RandevuSaati = saat,
                HastaInfo = info
            };
            OleDbCommand command = new OleDbCommand("insert into HastaBilgi (HastaAdSoyad,TelefonNo,Email,DoktorAdi,Bolum,RandevuTarihi,RandevuSaati,HastaInfo)values(@HastaAdSoyad,@TelefonNo,@Email,@DoktorAdi,@Bolum,@RandevuTarihi,@RandevuSaati,@HastaInfo)", connection);
           
            command.Parameters.AddWithValue("@HastaAdSoyad", kisiler.HastaAdSoyad);
            command.Parameters.AddWithValue("@TelefonNo", kisiler.TelefonNo);
            command.Parameters.AddWithValue("@Email", kisiler.Email);
            command.Parameters.AddWithValue("@DoktorAdi", kisiler.DoktorAdi);
            command.Parameters.AddWithValue("@Bolum", kisiler.Bolum);
            command.Parameters.AddWithValue("@RandevuTarihi", kisiler.RandevuTarihi);
            command.Parameters.AddWithValue("@RandevuSaati", kisiler.RandevuSaati);
            command.Parameters.AddWithValue("@HastaInfo", kisiler.HastaInfo);
            
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(string ad, string tel, string email, string doktoradi, string bolum, string tarih, string saat, string info)
        {
           
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            HastaBilgi kisiler = new HastaBilgi
            {

                HastaAdSoyad = ad,
                TelefonNo = tel,
                Email = email,
                DoktorAdi = doktoradi,
                Bolum = bolum,
                RandevuTarihi = tarih,
                RandevuSaati = saat,
                HastaInfo = info

            };
            OleDbCommand command = new OleDbCommand("UPDATE Kisiler SET HastaAdSoyad = @HastaAdSoyad,Email = @Email, TelefonNo =@TelefonNo,DoktorAdi = @DoktorAdi, RandevuTarihi =@RandevuTarihi,RandevuSaati =@RandevuSaati,HastaInfo=@HastaInfo,Bolum=@Bolum,HastaID=@HastaID WHERE KisilerID = @KisilerID", connection);
            command.Parameters.AddWithValue("@HastaAdSoyad", kisiler.HastaAdSoyad);
            command.Parameters.AddWithValue("@Email", kisiler.Email);
            command.Parameters.AddWithValue("@TelefonNo", kisiler.TelefonNo);
            command.Parameters.AddWithValue("@DoktorAdi", kisiler.DoktorAdi);
            command.Parameters.AddWithValue("@Bolum", kisiler.Bolum);
            command.Parameters.AddWithValue("@RandevuTarihi", kisiler.RandevuTarihi);
            command.Parameters.AddWithValue("@RandevuSaati", kisiler.RandevuSaati);
            command.Parameters.AddWithValue("@HastaInfo", kisiler.HastaInfo);
            command.Parameters.AddWithValue("@HastaID", kisiler.HastaID);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int ID)
        {
          
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            OleDbCommand command = new OleDbCommand("DELETE * FROM HastaBilg WHERE HastaID = @HastaID", connection);
            command.Parameters.AddWithValue("@HastaID", ID);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
