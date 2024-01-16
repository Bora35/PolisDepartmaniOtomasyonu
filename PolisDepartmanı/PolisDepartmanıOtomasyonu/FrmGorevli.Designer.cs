namespace PolisDepartmanıOtomasyonu
{
    partial class FrmGorevli
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
            this.BtnBilgiSil = new System.Windows.Forms.Button();
            this.BtnBilgiGetir = new System.Windows.Forms.Button();
            this.LstBoxBilgi = new System.Windows.Forms.ListBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSorgu = new System.Windows.Forms.TextBox();
            this.cBoxYetki = new System.Windows.Forms.CheckBox();
            this.TxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIptal = new System.Windows.Forms.Button();
            this.Join_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBilgiSil
            // 
            this.BtnBilgiSil.Location = new System.Drawing.Point(616, 271);
            this.BtnBilgiSil.Name = "BtnBilgiSil";
            this.BtnBilgiSil.Size = new System.Drawing.Size(148, 42);
            this.BtnBilgiSil.TabIndex = 4;
            this.BtnBilgiSil.Text = "Seçili Olanı Sil";
            this.BtnBilgiSil.UseVisualStyleBackColor = true;
            this.BtnBilgiSil.Click += new System.EventHandler(this.BtnBilgiSil_Click);
            // 
            // BtnBilgiGetir
            // 
            this.BtnBilgiGetir.Location = new System.Drawing.Point(464, 271);
            this.BtnBilgiGetir.Name = "BtnBilgiGetir";
            this.BtnBilgiGetir.Size = new System.Drawing.Size(146, 42);
            this.BtnBilgiGetir.TabIndex = 3;
            this.BtnBilgiGetir.Text = "Seçili Olanı Getir";
            this.BtnBilgiGetir.UseVisualStyleBackColor = true;
            this.BtnBilgiGetir.Click += new System.EventHandler(this.BtnBilgiGetir_Click);
            // 
            // LstBoxBilgi
            // 
            this.LstBoxBilgi.FormattingEnabled = true;
            this.LstBoxBilgi.ItemHeight = 16;
            this.LstBoxBilgi.Location = new System.Drawing.Point(464, 21);
            this.LstBoxBilgi.Name = "LstBoxBilgi";
            this.LstBoxBilgi.Size = new System.Drawing.Size(300, 244);
            this.LstBoxBilgi.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1109, 361);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnIptal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtSorgu);
            this.groupBox1.Controls.Add(this.BtnBilgiSil);
            this.groupBox1.Controls.Add(this.cBoxYetki);
            this.groupBox1.Controls.Add(this.BtnBilgiGetir);
            this.groupBox1.Controls.Add(this.TxtTelefon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LstBoxBilgi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtKullaniciAdi);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 323);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Menüsü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(814, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sorgula:";
            // 
            // TxtSorgu
            // 
            this.TxtSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSorgu.Location = new System.Drawing.Point(818, 132);
            this.TxtSorgu.Name = "TxtSorgu";
            this.TxtSorgu.Size = new System.Drawing.Size(252, 38);
            this.TxtSorgu.TabIndex = 15;
            this.TxtSorgu.TextChanged += new System.EventHandler(this.TxtSorgu_TextChanged);
            // 
            // cBoxYetki
            // 
            this.cBoxYetki.AutoSize = true;
            this.cBoxYetki.Location = new System.Drawing.Point(149, 221);
            this.cBoxYetki.Name = "cBoxYetki";
            this.cBoxYetki.Size = new System.Drawing.Size(18, 17);
            this.cBoxYetki.TabIndex = 12;
            this.cBoxYetki.UseVisualStyleBackColor = true;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(149, 178);
            this.TxtTelefon.Mask = "(999) 000-0000";
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(213, 22);
            this.TxtTelefon.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Yetkili:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon:";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(149, 43);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(213, 22);
            this.TxtKullaniciAdi.TabIndex = 7;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(135, 257);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(123, 42);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(6, 257);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(123, 42);
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(149, 133);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(213, 22);
            this.TxtSoyad.TabIndex = 5;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(149, 87);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(213, 22);
            this.TxtAd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // BtnIptal
            // 
            this.BtnIptal.Location = new System.Drawing.Point(264, 257);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(123, 42);
            this.BtnIptal.TabIndex = 17;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.UseVisualStyleBackColor = true;
            this.BtnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // Join_panel
            // 
            this.Join_panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Join_panel.Location = new System.Drawing.Point(-106, -50);
            this.Join_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Join_panel.Name = "Join_panel";
            this.Join_panel.Size = new System.Drawing.Size(1351, 450);
            this.Join_panel.TabIndex = 44;
            // 
            // FrmGorevli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 742);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Join_panel);
            this.Name = "FrmGorevli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkililer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGorevli_FormClosed);
            this.Load += new System.EventHandler(this.FrmGorevli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBilgiSil;
        private System.Windows.Forms.Button BtnBilgiGetir;
        private System.Windows.Forms.ListBox LstBoxBilgi;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TxtTelefon;
        private System.Windows.Forms.CheckBox cBoxYetki;
        private System.Windows.Forms.TextBox TxtSorgu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.Panel Join_panel;
    }
}