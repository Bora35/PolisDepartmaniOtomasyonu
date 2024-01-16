namespace PolisDepartmanıOtomasyonu
{
    partial class FrmBilgiDuzenle
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
            this.BtnIptal = new System.Windows.Forms.Button();
            this.TxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnIptal
            // 
            this.BtnIptal.Location = new System.Drawing.Point(212, 235);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(123, 42);
            this.BtnIptal.TabIndex = 30;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.UseVisualStyleBackColor = true;
            this.BtnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(160, 186);
            this.TxtTelefon.Mask = "(999) 000-0000";
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(213, 22);
            this.TxtTelefon.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Telefon:";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(160, 25);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(213, 22);
            this.TxtKullaniciAdi.TabIndex = 25;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(83, 235);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(123, 42);
            this.BtnGuncelle.TabIndex = 24;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(160, 141);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(213, 22);
            this.TxtSoyad.TabIndex = 23;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(160, 95);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(213, 22);
            this.TxtAd.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(160, 61);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(213, 22);
            this.TxtSifre.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Şifre:";
            // 
            // FrmBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 311);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnIptal);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBilgiDuzenle";
            this.Text = "FrmBilgiDuzenle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBilgiDuzenle_FormClosed);
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.MaskedTextBox TxtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label5;
    }
}