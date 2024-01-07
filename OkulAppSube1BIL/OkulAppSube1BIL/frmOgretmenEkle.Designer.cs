namespace OkulAppSube1BIL
{
    partial class frmOgretmenEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpOgretmen = new System.Windows.Forms.GroupBox();
            this.txtOgretmenAd = new System.Windows.Forms.TextBox();
            this.txtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.ogretmenAd = new System.Windows.Forms.Label();
            this.ogretmenSoyad = new System.Windows.Forms.Label();
            this.btnOgretmenKaydet = new System.Windows.Forms.Button();
            this.ogretmenTcNo = new System.Windows.Forms.Label();
            this.txtOgretmenTcNo = new System.Windows.Forms.TextBox();
            this.btnOgretmenGuncelle = new System.Windows.Forms.Button();
            this.btnOgretmenSil = new System.Windows.Forms.Button();
            this.grpOgretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.txtOgretmenTcNo);
            this.grpOgretmen.Controls.Add(this.ogretmenTcNo);
            this.grpOgretmen.Controls.Add(this.ogretmenSoyad);
            this.grpOgretmen.Controls.Add(this.ogretmenAd);
            this.grpOgretmen.Controls.Add(this.txtOgretmenSoyad);
            this.grpOgretmen.Controls.Add(this.txtOgretmenAd);
            this.grpOgretmen.Location = new System.Drawing.Point(277, 32);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Size = new System.Drawing.Size(336, 213);
            this.grpOgretmen.TabIndex = 0;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "Ogretmen";
            // 
            // txtOgretmenAd
            // 
            this.txtOgretmenAd.Location = new System.Drawing.Point(222, 48);
            this.txtOgretmenAd.Name = "txtOgretmenAd";
            this.txtOgretmenAd.Size = new System.Drawing.Size(100, 22);
            this.txtOgretmenAd.TabIndex = 0;
            // 
            // txtOgretmenSoyad
            // 
            this.txtOgretmenSoyad.Location = new System.Drawing.Point(222, 88);
            this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            this.txtOgretmenSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtOgretmenSoyad.TabIndex = 1;
            // 
            // ogretmenAd
            // 
            this.ogretmenAd.AutoSize = true;
            this.ogretmenAd.Location = new System.Drawing.Point(73, 48);
            this.ogretmenAd.Name = "ogretmenAd";
            this.ogretmenAd.Size = new System.Drawing.Size(24, 16);
            this.ogretmenAd.TabIndex = 2;
            this.ogretmenAd.Text = "Ad";
            // 
            // ogretmenSoyad
            // 
            this.ogretmenSoyad.AutoSize = true;
            this.ogretmenSoyad.Location = new System.Drawing.Point(73, 88);
            this.ogretmenSoyad.Name = "ogretmenSoyad";
            this.ogretmenSoyad.Size = new System.Drawing.Size(47, 16);
            this.ogretmenSoyad.TabIndex = 3;
            this.ogretmenSoyad.Text = "Soyad";
            // 
            // btnOgretmenKaydet
            // 
            this.btnOgretmenKaydet.Location = new System.Drawing.Point(293, 289);
            this.btnOgretmenKaydet.Name = "btnOgretmenKaydet";
            this.btnOgretmenKaydet.Size = new System.Drawing.Size(75, 39);
            this.btnOgretmenKaydet.TabIndex = 1;
            this.btnOgretmenKaydet.Text = "Kaydet";
            this.btnOgretmenKaydet.UseVisualStyleBackColor = true;
            this.btnOgretmenKaydet.Click += new System.EventHandler(this.btnOgretmenKaydet_Click);
            // 
            // ogretmenTcNo
            // 
            this.ogretmenTcNo.AutoSize = true;
            this.ogretmenTcNo.Location = new System.Drawing.Point(73, 131);
            this.ogretmenTcNo.Name = "ogretmenTcNo";
            this.ogretmenTcNo.Size = new System.Drawing.Size(41, 16);
            this.ogretmenTcNo.TabIndex = 4;
            this.ogretmenTcNo.Text = "TcNo";
            // 
            // txtOgretmenTcNo
            // 
            this.txtOgretmenTcNo.Location = new System.Drawing.Point(222, 131);
            this.txtOgretmenTcNo.Name = "txtOgretmenTcNo";
            this.txtOgretmenTcNo.Size = new System.Drawing.Size(100, 22);
            this.txtOgretmenTcNo.TabIndex = 5;
            // 
            // btnOgretmenGuncelle
            // 
            this.btnOgretmenGuncelle.Location = new System.Drawing.Point(396, 361);
            this.btnOgretmenGuncelle.Name = "btnOgretmenGuncelle";
            this.btnOgretmenGuncelle.Size = new System.Drawing.Size(75, 39);
            this.btnOgretmenGuncelle.TabIndex = 2;
            this.btnOgretmenGuncelle.Text = "Guncelle";
            this.btnOgretmenGuncelle.UseVisualStyleBackColor = true;
            this.btnOgretmenGuncelle.Click += new System.EventHandler(this.btnOgretmenGuncelle_Click);
            // 
            // btnOgretmenSil
            // 
            this.btnOgretmenSil.Location = new System.Drawing.Point(517, 289);
            this.btnOgretmenSil.Name = "btnOgretmenSil";
            this.btnOgretmenSil.Size = new System.Drawing.Size(75, 39);
            this.btnOgretmenSil.TabIndex = 3;
            this.btnOgretmenSil.Text = "Sil";
            this.btnOgretmenSil.UseVisualStyleBackColor = true;
            this.btnOgretmenSil.Click += new System.EventHandler(this.btnOgretmenSil_Click);
            // 
            // frmOgretmenEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOgretmenSil);
            this.Controls.Add(this.btnOgretmenGuncelle);
            this.Controls.Add(this.btnOgretmenKaydet);
            this.Controls.Add(this.grpOgretmen);
            this.Name = "frmOgretmenEkle";
            this.Text = "frmOgretmenEkle";
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgretmen;
        private System.Windows.Forms.TextBox txtOgretmenTcNo;
        private System.Windows.Forms.Label ogretmenTcNo;
        private System.Windows.Forms.Label ogretmenSoyad;
        private System.Windows.Forms.Label ogretmenAd;
        private System.Windows.Forms.TextBox txtOgretmenSoyad;
        private System.Windows.Forms.TextBox txtOgretmenAd;
        private System.Windows.Forms.Button btnOgretmenKaydet;
        private System.Windows.Forms.Button btnOgretmenGuncelle;
        private System.Windows.Forms.Button btnOgretmenSil;
    }
}