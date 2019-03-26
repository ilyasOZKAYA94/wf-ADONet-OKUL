using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wf_ADONET_OKUL.Models;

namespace wf_ADONET_OKUL.DataModel
{
    public class OgrenciServis : IOgrenciServis
    {
        SqlConnection conn = new SqlConnection(Genel.conStr);

        public List<Ogrenci> OgrenciListesi()
        {
            List<Ogrenci> listogrenci = new List<Ogrenci>();
            SqlCommand cmd = new SqlCommand("select * from Ogrenciler", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//dr içine kayıt gelmişse true,hiç kayıt gelmemişse false olacak.
                {
                    while (dr.Read())
                    {
                        Ogrenci o = new Ogrenci();
                        o.ID = Convert.ToInt32(dr[0]);
                        o.Adi = dr[1].ToString();
                        o.Soyadi= dr[2].ToString();
                        o.Telefon = dr[3].ToString();
                        o.Adres= dr[4].ToString();
                        o.TCKNo = dr[5].ToString();
                        o.TaksitSayisi = Convert.ToByte(dr[6]);
                        o.TaksitTutari = Convert.ToDouble(dr[7]);
                        o.SinifId= Convert.ToInt32(dr[8]);
                        
                        listogrenci.Add(o);

                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return listogrenci;
        }
        public bool OgrenciKontrolByTCKNo(string Tc)
        {
            bool Sonuc = false;
            SqlCommand cmd = new SqlCommand("Select * from Ogrenciler where TCKNo=@Tc", conn);
           
            cmd.Parameters.Add("@Tc", SqlDbType.VarChar).Value =Tc;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                 Sonuc = Convert.ToBoolean(cmd.ExecuteScalar());             

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            { conn.Close(); }
            return Sonuc;
        }
        public bool OgrenciEkle(Ogrenci o)
        {
            bool Sonuc = false;
            SqlCommand cmd = new SqlCommand("insert into Ogrenciler(Adi,Soyadi,Telefon,Adres,TCKNo,TaksitSayisi,TaksitTutari,SinifId) values (@Adi,@Soyadi,@Telefon,@Adres,@TCKNo,@TaksitSayisi,@TaksitTutari,@SinifId)", conn);
            cmd.Parameters.Add("@Adi", SqlDbType.VarChar).Value = o.Adi;
            cmd.Parameters.Add("@Soyadi", SqlDbType.VarChar).Value = o.Soyadi;
            cmd.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = o.Telefon;
            cmd.Parameters.Add("@Adres", SqlDbType.VarChar).Value = o.Adres;
            cmd.Parameters.Add("@TCKNo", SqlDbType.VarChar).Value = o.TCKNo;
            cmd.Parameters.Add("@TaksitSayisi", SqlDbType.TinyInt).Value = o.TaksitSayisi;
            cmd.Parameters.Add("@TaksitTutari", SqlDbType.Money).Value = o.TaksitTutari;
            cmd.Parameters.Add("@SinifId", SqlDbType.Int).Value = o.SinifId;


            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                
                if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                {
                    Sonuc = true;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return Sonuc;
        }

        public List<Ogrenci> Sorgulama(string ad,string soyad)
        {
            List<Ogrenci> Sorgu = new List<Ogrenci>();
            SqlCommand cmd = new SqlCommand("select * from Ogrenciler where Adi like @ad+'%' and Soyadi like @soyad+'%'", conn);
            cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = ad;
            cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = soyad;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//dr içine kayıt gelmişse true,hiç kayıt gelmemişse false olacak.
                {
                    while (dr.Read())
                    {
                        Ogrenci o = new Ogrenci();
                        o.ID = Convert.ToInt32(dr[0]);
                        o.Adi = dr[1].ToString();
                        o.Soyadi = dr[2].ToString();
                        o.Telefon = dr[3].ToString();
                        o.Adres = dr[4].ToString();
                        o.TCKNo = dr[5].ToString();
                        o.TaksitSayisi = Convert.ToByte(dr[6]);
                        o.TaksitTutari = Convert.ToDouble(dr[7]);
                        o.SinifId = Convert.ToInt32(dr[8]);

                        Sorgu.Add(o);

                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return Sorgu;

        }
        public Ogrenci OgrenciGetirById(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Ogrenci> OgrenciListesiGetirBySorgulama(int sinifId,string ad,string soyad,string tel,string adres)
        {
            List<Ogrenci> listogrenci = new List<Ogrenci>();
            SqlCommand cmd;
            if (sinifId == 0)
            {
                cmd = new SqlCommand("select * from Ogrenciler where Adi like @ad + '%' and Soyadi like @soyad+'%' and Telefon like @tel+'%' and Adres like '%'+@adres+'%'", conn);
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = ad;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = soyad;
                cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = adres;

            }
            else
            {
                 cmd = new SqlCommand("select * from Ogrenciler where SinifId=@sid and Adi like @ad+'%' and Soyadi like @soyad+'%' and Telefon like @tel+'%' and Adres like '%'+@adres+'%'", conn);

                cmd.Parameters.Add("@sid", SqlDbType.Int).Value = sinifId;
                cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = ad;
                cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = soyad;
                cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = tel;
                cmd.Parameters.Add("@adres", SqlDbType.VarChar).Value = adres;
            }

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//dr içine kayıt gelmişse true,hiç kayıt gelmemişse false olacak.
                {
                    while (dr.Read())
                    {
                        Ogrenci o = new Ogrenci();
                        o.ID = Convert.ToInt32(dr[0]);
                        o.Adi = dr[1].ToString();
                        o.Soyadi = dr[2].ToString();
                        o.Telefon = dr[3].ToString();
                        o.Adres = dr[4].ToString();
                        o.TCKNo = dr[5].ToString();
                        o.TaksitSayisi = Convert.ToByte(dr[6]);
                        o.TaksitTutari = Convert.ToDouble(dr[7]);
                        o.SinifId = Convert.ToInt32(dr[8]);

                        listogrenci.Add(o);

                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return listogrenci;
        }

        public bool OgrenciGuncelle(Ogrenci o)
        {
            bool Sonuc = false;
            SqlCommand cmd = new SqlCommand("update Ogrenciler set Adi=@Adi,Soyadi=@Soyadi,Telefon=@Telefon,Adres=@Adres,TCKNo=@TCKNo,TaksitSayisi=@TaksitSayisi,TaksitTutari=@TaksitTutari,SinifId=@SinifId where Id=@ID", conn);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = o.ID;
            cmd.Parameters.Add("@Adi", SqlDbType.VarChar).Value = o.Adi;
            cmd.Parameters.Add("@Soyadi", SqlDbType.VarChar).Value = o.Soyadi;
            cmd.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = o.Telefon;
            cmd.Parameters.Add("@Adres", SqlDbType.VarChar).Value = o.Adres;
            cmd.Parameters.Add("@TCKNo", SqlDbType.VarChar).Value = o.TCKNo;
            cmd.Parameters.Add("@TaksitSayisi", SqlDbType.TinyInt).Value = o.TaksitSayisi;
            cmd.Parameters.Add("@TaksitTutari", SqlDbType.Money).Value = o.TaksitTutari;
            cmd.Parameters.Add("@SinifId", SqlDbType.Int).Value = o.SinifId;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                bool Sonuc1 = Convert.ToBoolean(cmd.ExecuteNonQuery());
                if (Sonuc1)
                {
                    Sonuc = true;
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            { conn.Close(); }
            return Sonuc;
        }

       

        public bool OgrenciSil(int ID)
        {
            bool Sonuc = false;
            SqlCommand cmd = new SqlCommand("Delete from Ogrenciler where Id=@ID", conn);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                bool Sonuc1 = Convert.ToBoolean(cmd.ExecuteNonQuery());
                if (Sonuc1)
                {
                    Sonuc = true;
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            { conn.Close(); }
            return Sonuc;
        }

        public bool OgrenciSil(Ogrenci o)
        {
            throw new NotImplementedException();
        }
    }
}
