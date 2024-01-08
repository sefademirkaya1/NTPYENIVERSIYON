using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgrKayit : Form
    {
        public int Ogrenciid { get; set; }

        public frmOgrKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                bool sonuc = obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme Başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı öğrenci daha önce kayıtlı");
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

        private void btnBulOgr_Click(object sender, EventArgs e)
        {
            try
            {
                frmOgrBul frm = new frmOgrBul(this);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            btnGuncelle.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                bool sonuc2 = obl.OgrenciGuncelle(new Ogrenci
                {
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    Numara = txtNumara.Text.Trim(),
                    Ogrenciid = Ogrenciid
                });

                if (sonuc2)
                {
                    MessageBox.Show("Güncelleme Başarılı!");
                    btnGuncelle.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarısız!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var obl = new OgrenciBL();
            string numara = txtNumara.Text.Trim();

            if (!string.IsNullOrEmpty(numara))
            {
                bool sonuc = obl.OgrenciSil(numara);

                if (sonuc)
                {
                    MessageBox.Show("Öğrenci başarıyla silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Öğrenci silinirken bir hata oluştu.", "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNumara_TextChanged(object sender, EventArgs e)
        {
            btnSil.Enabled = !string.IsNullOrWhiteSpace(txtNumara.Text.Trim());
        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TextBoxlar temizlendi.");
            TemizleGroupBoxControls(grpOgrenci);
        }

        private void TemizleGroupBoxControls(Control temizle)
        {
            foreach (Control control in temizle.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        // frmOgrBul formundan gelen btnSil butonunu etkinleştir/devre dışı bırak
        public void EnableDisableBtnSil(bool enable)
        {
            btnSil.Enabled = enable;
        }
    }
}



//Güncelleme Başarılı mesajı
//Güncelleme butonu aktifliği?
//Silme butonu aktifliği
//Silme işlemi mesajı    
//Tüm işlemlerde try-catch
//Helperda bulunan connection ve commandlerin dispose edilmesi (IDisposable Pattern)
//Singleton Pattern (Sürkeli nesne oluşmadan tek nesne üstünden işlemlerin yapılması)
//Öğretmen entity'si için kalan CRUD işlemleri






// IDisposable Pattern :Disposable Pattern, nesne yönetimi ve kaynak temizleme (resource cleanup) için kullanılan bir tasarım desenidir.
// Bu desen, özellikle unmanaged (yönetilmeyen) kaynakları kullanırken ve nesnelerin bellekten düzenli bir şekilde
// serbest bırakılmasını sağlamak için kullanılır.
//Disposable Pattern, .NET'te IDisposable arayüzü üzerine kurulmuştur.
//Bu arayüz, Dispose metodunu tanımlar ve bir sınıf bu arayüzü uyguladığında, bu metodun çağrılması nesnenin temizlenmesini sağlar.
//---------------------------------------------------------------------------


// Singleton Pattern :Singleton Pattern, bir sınıfın yalnızca bir örneğinin (instance) oluşturulmasını ve bu örneğe global bir erişim noktası
// sağlanmasını sağlayan bir tasarım desenidir. Bu desen, bir sınıfın tek bir örneğini tutarak bu örneğe tüm uygulama genelinde tek bir noktadan erişmeyi sağlar.
// Singleton Pattern, genellikle kaynakları paylaşmak veya kontrol noktası sağlamak amacıyla kullanılır.






//interface ITransfer
//{
//    int Eft(string gondericiiban, string aliciiban, double tutar);
//    int Havale(string gondericiiban, string aliciiban, double tutar);

//}

//class Transfer : ITransfer
//{
//    public int Eft(string gondericiiban, string aliciiban, double tutar)
//    {
//        throw new NotImplementedException();
//    }

//    public int Havale(string gondericiiban, string aliciiban, double tutar)
//    {
//        throw new NotImplementedException();
//    }

//    //
//}


//Garbage Collector
