using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgrBul : Form
    {
        frmOgrKayit frm;

        public frmOgrBul(frmOgrKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                Ogrenci ogr = obl.OgrenciBul(txtOgrNo.Text.Trim());

                if (ogr != null)
                {
                    frm.txtAd.Text = ogr.Ad;
                    frm.txtSoyad.Text = ogr.Soyad;
                    frm.txtNumara.Text = ogr.Numara;
                    frm.Ogrenciid = ogr.Ogrenciid;

                    this.Close();

                    frm.EnableDisableBtnSil(true);
                    frm.EnableDisableBtnGuncelle(true);
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Öğrenci bulunamadığında btnSil ve btnGuncelle'yi devre dışı bırak
                    frm.EnableDisableBtnSil(false);
                    frm.EnableDisableBtnGuncelle(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
