using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using DAL;
using System.Windows.Forms;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {
            SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@Numara",ogr.Numara)
                         };

            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into dblogrenciler values(@Ad,@Soyad,@Numara)", p) > 0;

        }

        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            SqlParameter[] p = {
                             new SqlParameter("@Ad",ogr.Ad),
                             new SqlParameter("@Soyad",ogr.Soyad),
                             new SqlParameter("@Numara",ogr.Numara),
                             new SqlParameter("@Ogrenciid",ogr.Ogrenciid)
                         };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Update dblogrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara where OgrenciId=@Ogrenciid", p) > 0;
        }

        public bool OgrenciSil(string numara)
        {
            SqlParameter[] p = { new SqlParameter("@Numara", numara) };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Delete from dblogrenciler where Numara=@Numara", p) > 0;
        }



        public Ogrenci OgrenciBul(string numara)
        {
            SqlParameter[] p = { new SqlParameter("@Numara", numara) };
            Helper hlp = new Helper();
            var dr = hlp.ExecuteReader("Select OgrenciId,Ad,Soyad,Numara from dblogrenciler where Numara=@Numara", p);
            Ogrenci ogr = null;
            if (dr.Read())
            {
                ogr = new Ogrenci();
                ogr.Ogrenciid = Convert.ToInt32(dr["OgrenciId"]);
                ogr.Ad = dr["Ad"].ToString();
                ogr.Soyad = dr["Soyad"].ToString();
                ogr.Numara = dr["Numara"].ToString();
            }
            dr.Close();
            return ogr;
        }
    }
}
//n Katmanlı Mimari