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
    class SinifServis : ISinifServis
    {

        SqlConnection conn = new SqlConnection(Genel.conStr);


        public List<Sinif> SinifListesi()
        {
            List<Sinif> listsinif = new List<Sinif>();
            SqlCommand cmd = new SqlCommand("select * from Siniflar", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//dr içine kayıt gelmişse true,hiç kayıt gelmemişse false olacak.
                {
                    while (dr.Read())
                    {
                        Sinif s = new Sinif();
                        s.Id = Convert.ToInt32(dr[0]);
                        s.SinifAdi =dr[1].ToString();
                        s.AcilisTarihi = Convert.ToDateTime(dr[2]);
                        s.KapanisTarihi = Convert.ToDateTime(dr[3]);
                        s.OgretmenId = Convert.ToInt32(dr[4]);
                        s.Aciklama = dr[5].ToString();

                        listsinif.Add(s);

                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return listsinif;
        }
        public List<SinifModel> SinifModelListesi()
        {
            List<SinifModel> listsinif = new List<SinifModel>();
            SqlCommand cmd = new SqlCommand("select Id,SinifAdi from Siniflar", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.HasRows)//dr içine kayıt gelmişse true,hiç kayıt gelmemişse false olacak.
                {
                    while (dr.Read())
                    {
                        SinifModel sm = new SinifModel();
                        sm.Id = Convert.ToInt32(dr[0]);
                        sm.SinifAdi = dr[1].ToString();


                        listsinif.Add(sm);

                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

            return listsinif;
        }

        public bool SinifEkle(Sinif s)
        {
            throw new NotImplementedException();
        }

        public Sinif SinifGetirById(int ID)
        {
            throw new NotImplementedException();
        }

        public bool SinifGuncelle(Sinif s)
        {
            throw new NotImplementedException();
        }


        public bool SinifSil(int ID)
        {
            throw new NotImplementedException();
        }

        public bool SinifSil(Sinif s)
        {
            throw new NotImplementedException();
        }
    }
}
