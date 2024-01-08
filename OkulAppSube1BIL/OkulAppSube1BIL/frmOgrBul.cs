using OkulApp.BLL;
using OkulApp.MODEL;
using System.Windows.Forms;
using System;

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
            var obl = new OgrenciBL();
            Ogrenci ogr = obl.OgrenciBul(txtOgrNo.Text.Trim());

            if (ogr != null)
            {
                frm.txtAd.Text = ogr.Ad;
                frm.txtSoyad.Text = ogr.Soyad;
                frm.txtNumara.Text = ogr.Numara;
                frm.Ogrenciid = ogr.Ogrenciid;

                this.Close();
            }
            else
           {
             MessageBox.Show("Öğrenci bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


                //öğrenci bulunduğunda formu kapat
                this.Close();

                
                frm.EnableDisableBtnSil(true);
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Öğrenci bulunamadığında btnSil'i devre dışı bırak
                frm.EnableDisableBtnSil(false);
            }
        }
    }
}
