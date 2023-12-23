namespace OkulAppSube1BIL
{
    partial class frmOgretmenKayit
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
            this.lblOgretAd = new System.Windows.Forms.Label();
            this.lblOgretSoyad = new System.Windows.Forms.Label();
            this.lblOgetTcNo = new System.Windows.Forms.Label();
            this.txtOgretAd = new System.Windows.Forms.TextBox();
            this.txtOgretSoyad = new System.Windows.Forms.TextBox();
            this.txtOgretTcNo = new System.Windows.Forms.TextBox();
            this.btnOgretGonder = new System.Windows.Forms.Button();
            this.grpOgretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.txtOgretTcNo);
            this.grpOgretmen.Controls.Add(this.txtOgretSoyad);
            this.grpOgretmen.Controls.Add(this.txtOgretAd);
            this.grpOgretmen.Controls.Add(this.lblOgetTcNo);
            this.grpOgretmen.Controls.Add(this.lblOgretSoyad);
            this.grpOgretmen.Controls.Add(this.lblOgretAd);
            this.grpOgretmen.Location = new System.Drawing.Point(192, 64);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Size = new System.Drawing.Size(300, 167);
            this.grpOgretmen.TabIndex = 0;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "OgretmenBilgileri";
            // 
            // lblOgretAd
            // 
            this.lblOgretAd.AutoSize = true;
            this.lblOgretAd.Location = new System.Drawing.Point(30, 47);
            this.lblOgretAd.Name = "lblOgretAd";
            this.lblOgretAd.Size = new System.Drawing.Size(24, 16);
            this.lblOgretAd.TabIndex = 0;
            this.lblOgretAd.Text = "Ad";
            // 
            // lblOgretSoyad
            // 
            this.lblOgretSoyad.AutoSize = true;
            this.lblOgretSoyad.Location = new System.Drawing.Point(30, 72);
            this.lblOgretSoyad.Name = "lblOgretSoyad";
            this.lblOgretSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblOgretSoyad.TabIndex = 1;
            this.lblOgretSoyad.Text = "Soyad";
            // 
            // lblOgetTcNo
            // 
            this.lblOgetTcNo.AutoSize = true;
            this.lblOgetTcNo.Location = new System.Drawing.Point(30, 97);
            this.lblOgetTcNo.Name = "lblOgetTcNo";
            this.lblOgetTcNo.Size = new System.Drawing.Size(41, 16);
            this.lblOgetTcNo.TabIndex = 2;
            this.lblOgetTcNo.Text = "TcNo";
            // 
            // txtOgretAd
            // 
            this.txtOgretAd.Location = new System.Drawing.Point(101, 44);
            this.txtOgretAd.Name = "txtOgretAd";
            this.txtOgretAd.Size = new System.Drawing.Size(51, 22);
            this.txtOgretAd.TabIndex = 3;
            // 
            // txtOgretSoyad
            // 
            this.txtOgretSoyad.Location = new System.Drawing.Point(101, 72);
            this.txtOgretSoyad.Name = "txtOgretSoyad";
            this.txtOgretSoyad.Size = new System.Drawing.Size(51, 22);
            this.txtOgretSoyad.TabIndex = 4;
            // 
            // txtOgretTcNo
            // 
            this.txtOgretTcNo.Location = new System.Drawing.Point(101, 100);
            this.txtOgretTcNo.Name = "txtOgretTcNo";
            this.txtOgretTcNo.Size = new System.Drawing.Size(51, 22);
            this.txtOgretTcNo.TabIndex = 5;
            // 
            // btnOgretGonder
            // 
            this.btnOgretGonder.Location = new System.Drawing.Point(269, 260);
            this.btnOgretGonder.Name = "btnOgretGonder";
            this.btnOgretGonder.Size = new System.Drawing.Size(75, 23);
            this.btnOgretGonder.TabIndex = 1;
            this.btnOgretGonder.Text = "Kaydet";
            this.btnOgretGonder.UseVisualStyleBackColor = true;
            this.btnOgretGonder.Click += new System.EventHandler(this.btnOgretGonder_Click);
            // 
            // frmOgretmenEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOgretGonder);
            this.Controls.Add(this.grpOgretmen);
            this.Name = "frmOgretmenEkle";
            this.Text = "frmOgretmenEkle";
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgretmen;
        private System.Windows.Forms.TextBox txtOgretTcNo;
        private System.Windows.Forms.TextBox txtOgretSoyad;
        private System.Windows.Forms.TextBox txtOgretAd;
        private System.Windows.Forms.Label lblOgetTcNo;
        private System.Windows.Forms.Label lblOgretSoyad;
        private System.Windows.Forms.Label lblOgretAd;
        private System.Windows.Forms.Button btnOgretGonder;
    }
}