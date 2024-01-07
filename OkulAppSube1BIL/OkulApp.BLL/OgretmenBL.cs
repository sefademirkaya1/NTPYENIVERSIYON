﻿using DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {


        public bool OgretmenEkle(Ogretmen ogret)
        {
            SqlParameter[] p = {
                             new SqlParameter("@Ad",ogret.Ad),
                             new SqlParameter("@Soyad",ogret.Soyad),
                             new SqlParameter("@TcNo",ogret.TcNo)
                         };

            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into dblogretmenler values(@Ad,@Soyad,@TcNo)", p) > 0;

        }

        public bool OgretmenSil(string tcNo)
        {
            SqlParameter[] p = { new SqlParameter("@TcNo", tcNo) };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("DELETE FROM dblogretmenler WHERE TcNo = @TcNo", p) > 0;
        }

        public bool OgretmenGuncelle(Ogretmen ogret)
        {
            SqlParameter[] p = {
        new SqlParameter("@Ad", ogret.Ad),
        new SqlParameter("@Soyad", ogret.Soyad),
        new SqlParameter("@TcNo", ogret.TcNo),
        new SqlParameter("@OgretmenId", ogret.OgretmenId) // Öğretmenin kimliği
    };

            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("UPDATE dblogretmenler SET Ad=@Ad, Soyad=@Soyad, TcNo=@TcNo WHERE OgretmenId=@OgretmenId", p) > 0;
        }

    }
}