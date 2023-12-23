using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgretmenKayit : Form
    {
        public frmOgretmenKayit()
        {
            InitializeComponent();
        }

        private void btnOgretGonder_Click(object sender, EventArgs e)
        {
            try
            {
                var ogret = new OgretmenBL();
                bool sonuc = ogret.OgretmenEkle(new Ogretmen { Ad = txtOgretAd.Text.Trim(), Soyad = txtOgretSoyad.Text.Trim(), TcNo = txtOgretTcNo.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme Başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu TC KİMLİK NUMARASINA SAHİP ÖĞRETMEN DAHA ÖNCE KAYIT OLDU!!!");
                        break;
                    default:
                        MessageBox.Show("Veritabanı hatası");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }
    }
    }

