﻿namespace PolisDepartmanıOtomasyonu
{
    partial class FrmSuclu
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
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSorgu = new System.Windows.Forms.TextBox();
            this.BtnBilgiSil = new System.Windows.Forms.Button();
            this.BtnBilgiGetir = new System.Windows.Forms.Button();
            this.TxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LstBoxBilgi = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtYetkiliAdi = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSuclar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateCezaAlma = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateCezaBitis = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.LstBoxCinsiyet = new System.Windows.Forms.CheckedListBox();
            this.dateDogum = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.TxtMahkumId = new System.Windows.Forms.TextBox();
            this.Join_panel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIptal
            // 
            this.BtnIptal.Location = new System.Drawing.Point(736, 202);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(123, 42);
            this.BtnIptal.TabIndex = 17;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.UseVisualStyleBackColor = true;
            this.BtnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1048, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sorgula:";
            // 
            // TxtSorgu
            // 
            this.TxtSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSorgu.Location = new System.Drawing.Point(1052, 44);
            this.TxtSorgu.Name = "TxtSorgu";
            this.TxtSorgu.Size = new System.Drawing.Size(252, 38);
            this.TxtSorgu.TabIndex = 15;
            this.TxtSorgu.TextChanged += new System.EventHandler(this.TxtSorgu_TextChanged);
            // 
            // BtnBilgiSil
            // 
            this.BtnBilgiSil.Location = new System.Drawing.Point(1183, 222);
            this.BtnBilgiSil.Name = "BtnBilgiSil";
            this.BtnBilgiSil.Size = new System.Drawing.Size(121, 42);
            this.BtnBilgiSil.TabIndex = 4;
            this.BtnBilgiSil.Text = "Seçili Olanı Sil";
            this.BtnBilgiSil.UseVisualStyleBackColor = true;
            this.BtnBilgiSil.Click += new System.EventHandler(this.BtnBilgiSil_Click);
            // 
            // BtnBilgiGetir
            // 
            this.BtnBilgiGetir.Location = new System.Drawing.Point(1052, 222);
            this.BtnBilgiGetir.Name = "BtnBilgiGetir";
            this.BtnBilgiGetir.Size = new System.Drawing.Size(125, 42);
            this.BtnBilgiGetir.TabIndex = 3;
            this.BtnBilgiGetir.Text = "Seçili Olanı Getir";
            this.BtnBilgiGetir.UseVisualStyleBackColor = true;
            this.BtnBilgiGetir.Click += new System.EventHandler(this.BtnBilgiGetir_Click);
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(149, 222);
            this.TxtTelefon.Mask = "(999) 000-0000";
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(213, 22);
            this.TxtTelefon.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cinsiyet:";
            // 
            // LstBoxBilgi
            // 
            this.LstBoxBilgi.FormattingEnabled = true;
            this.LstBoxBilgi.ItemHeight = 16;
            this.LstBoxBilgi.Location = new System.Drawing.Point(1052, 100);
            this.LstBoxBilgi.Name = "LstBoxBilgi";
            this.LstBoxBilgi.Size = new System.Drawing.Size(252, 116);
            this.LstBoxBilgi.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon:";
            // 
            // TxtYetkiliAdi
            // 
            this.TxtYetkiliAdi.Enabled = false;
            this.TxtYetkiliAdi.Location = new System.Drawing.Point(149, 43);
            this.TxtYetkiliAdi.Name = "TxtYetkiliAdi";
            this.TxtYetkiliAdi.Size = new System.Drawing.Size(213, 22);
            this.TxtYetkiliAdi.TabIndex = 7;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(597, 199);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(123, 42);
            this.BtnGuncelle.TabIndex = 6;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(462, 199);
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
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yetkili Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMahkumId);
            this.groupBox1.Controls.Add(this.TxtSuclar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateCezaAlma);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateCezaBitis);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LstBoxCinsiyet);
            this.groupBox1.Controls.Add(this.dateDogum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BtnIptal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtSorgu);
            this.groupBox1.Controls.Add(this.BtnBilgiSil);
            this.groupBox1.Controls.Add(this.BtnBilgiGetir);
            this.groupBox1.Controls.Add(this.TxtTelefon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LstBoxBilgi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtYetkiliAdi);
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1322, 346);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Menüsü";
            // 
            // TxtSuclar
            // 
            this.TxtSuclar.Location = new System.Drawing.Point(539, 41);
            this.TxtSuclar.Name = "TxtSuclar";
            this.TxtSuclar.Size = new System.Drawing.Size(320, 22);
            this.TxtSuclar.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(458, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Suçlar :";
            // 
            // dateCezaAlma
            // 
            this.dateCezaAlma.Location = new System.Drawing.Point(646, 89);
            this.dateCezaAlma.Name = "dateCezaAlma";
            this.dateCezaAlma.Size = new System.Drawing.Size(213, 22);
            this.dateCezaAlma.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(458, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ceza Alma Tarihi :";
            // 
            // dateCezaBitis
            // 
            this.dateCezaBitis.Location = new System.Drawing.Point(646, 135);
            this.dateCezaBitis.Name = "dateCezaBitis";
            this.dateCezaBitis.Size = new System.Drawing.Size(213, 22);
            this.dateCezaBitis.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(458, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ceza Bitiş Tarihi :";
            // 
            // LstBoxCinsiyet
            // 
            this.LstBoxCinsiyet.FormattingEnabled = true;
            this.LstBoxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Diğer"});
            this.LstBoxCinsiyet.Location = new System.Drawing.Point(149, 258);
            this.LstBoxCinsiyet.Name = "LstBoxCinsiyet";
            this.LstBoxCinsiyet.Size = new System.Drawing.Size(213, 72);
            this.LstBoxCinsiyet.TabIndex = 20;
            // 
            // dateDogum
            // 
            this.dateDogum.Location = new System.Drawing.Point(149, 176);
            this.dateDogum.Name = "dateDogum";
            this.dateDogum.Size = new System.Drawing.Size(213, 22);
            this.dateDogum.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Doğum Tarihi:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1322, 361);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // TxtMahkumId
            // 
            this.TxtMahkumId.Enabled = false;
            this.TxtMahkumId.Location = new System.Drawing.Point(149, 15);
            this.TxtMahkumId.Name = "TxtMahkumId";
            this.TxtMahkumId.Size = new System.Drawing.Size(213, 22);
            this.TxtMahkumId.TabIndex = 31;
            this.TxtMahkumId.Visible = false;
            // 
            // Join_panel
            // 
            this.Join_panel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Join_panel.Location = new System.Drawing.Point(-6, -18);
            this.Join_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Join_panel.Name = "Join_panel";
            this.Join_panel.Size = new System.Drawing.Size(1370, 412);
            this.Join_panel.TabIndex = 43;
            // 
            // FrmSuclu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 759);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Join_panel);
            this.Name = "FrmSuclu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suçlular";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSuclu_FormClosed);
            this.Load += new System.EventHandler(this.FrmSuclu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSorgu;
        private System.Windows.Forms.Button BtnBilgiSil;
        private System.Windows.Forms.Button BtnBilgiGetir;
        private System.Windows.Forms.MaskedTextBox TxtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LstBoxBilgi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtYetkiliAdi;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.CheckedListBox LstBoxCinsiyet;
        private System.Windows.Forms.DateTimePicker dateDogum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSuclar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateCezaAlma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateCezaBitis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtMahkumId;
        private System.Windows.Forms.Panel Join_panel;
    }
}