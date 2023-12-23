using DAL;
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




    }
}
