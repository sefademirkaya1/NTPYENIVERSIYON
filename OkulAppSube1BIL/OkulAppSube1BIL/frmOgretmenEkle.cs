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
    public partial class frmOgretmenEkle : Form
    {
        public frmOgretmenEkle()
        {
            InitializeComponent();
        }

        private void btnOgretmenKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var ogret = new OgretmenBL();
                bool sonuc = ogret.OgretmenEkle(new Ogretmen { Ad = txtOgretmenAd.Text.Trim(), Soyad = txtOgretmenSoyad.Text.Trim(), TcNo = txtOgretmenTcNo.Text.Trim() });
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
        }
        private void btnOgretmenSil_Click(object sender, EventArgs e)
        {
            try
            {
                var ogretmenBL = new OgretmenBL();

                // Öğretmenin TC kimlik numarası
                string tcNo = txtOgretmenTcNo.Text.Trim();

                if (!string.IsNullOrEmpty(tcNo))
                {
                    bool sonuc = ogretmenBL.OgretmenSil(tcNo);

                    if (sonuc)
                    {
                        MessageBox.Show("Öğretmen başarıyla silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Öğretmen silinirken bir hata oluştu.", "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen öğretmenin TC kimlik numarasını girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var ogretmenBL = new OgretmenBL();

              
                string ad = txtOgretmenAd.Text.Trim();
                string soyad = txtOgretmenSoyad.Text.Trim();
                string tcNo = txtOgretmenTcNo.Text.Trim();

          
                Ogretmen ogretmen = new Ogretmen
                {
                
                    Ad = ad,
                    Soyad = soyad,
                    TcNo = tcNo
                };

                bool sonuc = ogretmenBL.OgretmenGuncelle(ogretmen);

                if (sonuc)
                {
                    MessageBox.Show("Öğretmen başarıyla güncellendi.", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                else
                {
                    MessageBox.Show("Öğretmen güncellenirken bir hata oluştu.", "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
